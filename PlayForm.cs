using SumoMVC.Models;
using SumoMVC.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SumoMVC
{
    public partial class PlayForm : Form
    {
        IGameModel gameModel;
        Rectangle Map;
        Rectangle player1Space;
        Rectangle player2Space;
        Rectangle foodSpace;
        Food food1;
        private DateTime startTime;
        public TimeSpan time;
        private int _ticks; 
        public PlayForm(IGameModel gameModel)
        {
            InitializeComponent();
            player1.Enabled = true;
            player2.Enabled = true;
            _ticks = 0;

            this.gameModel=gameModel;

            Map = new Rectangle(innerRing.Left, innerRing.Top, innerRing.Width, innerRing.Height);
            //ustawiamy graczy w początkowych lokalizacjach
            player1.Location = new Point(innerRing.Left, innerRing.Top);
            player2.Location = new Point(innerRing.Right-player1.Width, innerRing.Bottom - player2.Width);
            food1 = new Food();
            startTime = DateTime.Now;
        }


        private void PlayForm_Load(object sender, EventArgs e)
        {
            player1.Focus();
            player2.Focus();
            this.KeyDown += new KeyEventHandler(MovingStandard);
            timer2.Start();
        }
        public void MovingStandard(object sender, KeyEventArgs e)
        {
            int step = 10; // Step size for character movement

            if (e.KeyCode == Keys.Left && Map.IntersectsWith(player2Space) && player2.Left - step >= Map.Left)
            {
                player2.Left -= step;
                gameModel.Player2.x = player2.Left;
                gameModel.Player2.Weight--;
            }
            else if (e.KeyCode == Keys.Right && Map.IntersectsWith(player2Space) && player2.Right + step <= Map.Right)
            {
                player2.Left += step;
                gameModel.Player2.x = player2.Left;
                gameModel.Player2.Weight--;
            }
            else if (e.KeyCode == Keys.Up && Map.IntersectsWith(player2Space) && player2.Top - step >= Map.Top)
            {
                player2.Top -= step;
                gameModel.Player2.y = player2.Top;
                gameModel.Player2.Weight--;
            }
            else if (e.KeyCode == Keys.Down && Map.IntersectsWith(player2Space) && player2.Bottom + step <= Map.Bottom)
            {
                player2.Top += step;
                gameModel.Player2.y = player2.Top;
                gameModel.Player2.Weight--;
            }
            else if (e.KeyCode == Keys.A && Map.IntersectsWith(player1Space) && player1.Left - step >= Map.Left)
            {
                player1.Left -= step;
                gameModel.Player1.x = player1.Left;
                gameModel.Player1.Weight--;
            }
            else if (e.KeyCode == Keys.D && Map.IntersectsWith(player1Space) && player1.Right + step <= Map.Right)
            {
                player1.Left += step;
                gameModel.Player1.x = player1.Left;
                gameModel.Player1.Weight--;
            }
            else if (e.KeyCode == Keys.W && Map.IntersectsWith(player1Space) && player1.Top - step >= Map.Top)
            {
                player1.Top -= step;
                gameModel.Player1.y = player1.Top;
                gameModel.Player1.Weight--;
            }
            else if (e.KeyCode == Keys.S && Map.IntersectsWith(player1Space) && player1.Bottom + step <= Map.Bottom)
            {
                player1.Top += step;
                gameModel.Player1.y = player1.Top;
                gameModel.Player1.Weight--;
            }

            player1Space = new Rectangle(player1.Left, player1.Top, player1.Width, player1.Height);
            player2Space = new Rectangle(player2.Left, player2.Top, player2.Width, player2.Height);

            if ( IsIntersectionOverXPercent(player1Space,foodSpace,50f)&& food1.Eaten==false)
            { 
                gameModel.Player1.Weight += food1.kg;
                food1.Eaten = true;
                food.Hide();
            }
            else if (IsIntersectionOverXPercent(player2Space, foodSpace, 50f) && food1.Eaten == false)
            {
                gameModel.Player2.Weight += food1.kg;
                food1.Eaten = true;
                food.Hide();
            }
            
            FoodGenerator();
            PlayerInfo();

            if (FinishCondition(player1Space, player2Space) == 1)
            {
                MessageBox.Show(gameModel.Player1.Nick+" won");
                time = DateTime.Now-startTime;
                Close();
            } 
            else if (FinishCondition(player1Space, player2Space) == 2)   
            { 
                MessageBox.Show(gameModel.Player2.Nick+" won");
                time = DateTime.Now - startTime;
                Close(); 
            }            

        }
        private void FoodGenerator()
        {
            Random random = new Random();
            int randNumber = random.Next(10, 60);

            if (randNumber % 5 == 0 && food1.Eaten == true)  //jeśli jedzonko zostało już zjedzone, to moze powstać nowe
            {
                food1.Eaten = false;
                food1.kg = randNumber;
                food.Left = random.Next(innerRing.Left, innerRing.Right - food.Width);
                food.Top = random.Next(innerRing.Top, innerRing.Bottom - food.Height);
                food1.x = food.Left;
                food1.y = food.Top;
                foodSpace = new Rectangle(food.Left, food.Top, food.Width, food.Height);
                food.Show();
            }
        }

        private int FinishCondition(Rectangle player1Space, Rectangle player2Space)
        {
            if (gameModel.Player1.Weight <= 0 || gameModel.Player2.Weight <= 0)
            return gameModel.Player1.Weight > gameModel.Player2.Weight ? 1 : 2; 
            else {
                if (IsIntersectionOverXPercent(player1Space, player2Space, 60f))
                {
                    return gameModel.Player1.Weight > gameModel.Player2.Weight ? 1 : 2;
                }
            }
            return 0;
        }

        private bool IsIntersectionOverXPercent(Rectangle rect1, Rectangle rect2, float x)
        {
            float intersectionArea = Rectangle.Intersect(rect1, rect2).Width * Rectangle.Intersect(rect1, rect2).Height;

            // Oblicz 50% obszaru dla obu obszarów
            float halfRect1Area = rect1.Width * rect1.Height * x / 100;
            float halfRect2Area = rect2.Width * rect2.Height * x / 100;

            // Sprawdź, czy pole przecięcia stanowi co najmniej 50% obszaru jednego z obszarów
            return intersectionArea >= halfRect1Area || intersectionArea >= halfRect2Area;
        }

        private void PlayerInfo()
        {

            p1Info.Text = "Name:\n" + gameModel.Player1.Nick + "\nWeight:\n" + gameModel.Player1.Weight;
            p2Info.Text = "Name:\n " + gameModel.Player2.Nick + "\nWeight:\n" + gameModel.Player2.Weight;

            if (gameModel.Player1.Weight > gameModel.Player2.Weight)
            {
                p1Info.ForeColor = Color.Green;
                p2Info.ForeColor = Color.DarkRed;
            }
            else if(gameModel.Player2.Weight > gameModel.Player1.Weight)
            {
                p2Info.ForeColor = Color.Green;
                p1Info.ForeColor = Color.DarkRed;

            }
            else
            {
                p1Info.ForeColor = Color.DarkRed;
                p2Info.ForeColor = Color.DarkRed;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _ticks++;
            TimeText.Text = "" + _ticks;
        }
    }
}
