using SumoMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumoMVC
{
    public partial class PlayObstacleForm : Form
    {
        IGameModel gameModel;
        Rectangle Map;
        Rectangle player1Space;
        Rectangle player2Space;
        Rectangle foodSpace;
        Rectangle obstacle1Space;
        Rectangle obstacle2Space;
        Rectangle obstacle3Space;

        Food food1;
        private DateTime startTime;
        public TimeSpan time;
        private int _ticks;
        public PlayObstacleForm(IGameModel gameModel)
        {
            InitializeComponent();
            player1.Enabled = true;
            player2.Enabled = true;
            _ticks = 0;

            this.gameModel = gameModel;

            Map = new Rectangle(innerRing.Left, innerRing.Top, innerRing.Width, innerRing.Height);
            obstacle1.Location = new Point(innerRing.Left + player1.Width, innerRing.Top);
            obstacle2.Location = new Point(innerRing.Right - obstacle2.Width, innerRing.Bottom - 2 * player1.Height);
            obstacle3.Location = new Point(innerRing.Left, innerRing.Bottom-obstacle3.Height);

            obstacle1Space = new Rectangle(obstacle1.Left, obstacle1.Top, obstacle1.Width, obstacle1.Height);
            obstacle2Space = new Rectangle(obstacle2.Left, obstacle2.Top, obstacle2.Width, obstacle2.Height);
            obstacle3Space = new Rectangle(obstacle3.Left, obstacle3.Top, obstacle3.Width, obstacle3.Height);
            
            //ustawiamy graczy w początkowych lokalizacjach
            player1.Location = new Point(innerRing.Left, innerRing.Top);
            player2.Location = new Point(innerRing.Right - player1.Width, innerRing.Bottom - player2.Width);
            food1 = new Food();
            startTime = DateTime.Now;
        }

        private void PlayObstacleForm_Load(object sender, EventArgs e)
        {
            player1.Focus();
            player2.Focus();
            this.KeyDown += new KeyEventHandler(MovingObstacle);
            timer1.Start();
        }

        public void MovingObstacle(object sender, KeyEventArgs e)
        {
            int step = 5; // Step size for character movement
            if (e.KeyCode == Keys.Left && Map.IntersectsWith(player2Space) && player2.Left - step >= Map.Left
  &&!checkCollision(new Rectangle(player2.Left-step, player2.Top, player2.Width, player2.Height))
)
            {
                player2.Left -= step;
                gameModel.Player2.x = player2.Left;
                gameModel.Player2.Weight--;
            }
            else if (e.KeyCode == Keys.Right && Map.IntersectsWith(player2Space) && player2.Right + step <= Map.Right
                  && !checkCollision(new Rectangle(player2.Left + step, player2.Top, player2.Width, player2.Height))
)
            {
                player2.Left += step;
                gameModel.Player2.x = player2.Left;
                gameModel.Player2.Weight--;
            }
            else if (e.KeyCode == Keys.Up && Map.IntersectsWith(player2Space) && player2.Top - step >= Map.Top
                  && !checkCollision(new Rectangle(player2.Left, player2.Top - step, player2.Width, player2.Height))
)
            {
                player2.Top -= step;
                gameModel.Player2.y = player2.Top;
                gameModel.Player2.Weight--;
            }
            else if (e.KeyCode == Keys.Down && Map.IntersectsWith(player2Space) && player2.Bottom + step <= Map.Bottom
            && !checkCollision(new Rectangle(player2.Left, player2.Top + step, player2.Width, player2.Height))
            )
            {
                player2.Top += step;
                gameModel.Player2.y = player2.Top;
                gameModel.Player2.Weight--;
            }
            else if (e.KeyCode == Keys.A && Map.IntersectsWith(player1Space) && player1.Left - step >= Map.Left
                            && !checkCollision(new Rectangle(player1.Left-step, player1.Top, player1.Width, player1.Height))

                )
            {
                player1.Left -= step;
                gameModel.Player1.x = player1.Left;
                gameModel.Player1.Weight--;
            }
            else if (e.KeyCode == Keys.D && Map.IntersectsWith(player1Space) && player1.Right + step <= Map.Right
              && !checkCollision(new Rectangle(player1.Left + step, player1.Top, player1.Width, player1.Height))
)
            {
                player1.Left += step;
                gameModel.Player1.x = player1.Left;
                gameModel.Player1.Weight--;
            }
            else if (e.KeyCode == Keys.W && Map.IntersectsWith(player1Space) && player1.Top - step >= Map.Top
                                            && !checkCollision(new Rectangle(player1.Left , player1.Top-step, player1.Width, player1.Height))
)
            {
                player1.Top -= step;
                gameModel.Player1.y = player1.Top;
                gameModel.Player1.Weight--;
            }
            else if (e.KeyCode == Keys.S && Map.IntersectsWith(player1Space) && player1.Bottom + step <= Map.Bottom
                                                            && !checkCollision(new Rectangle(player1.Left, player1.Top + step, player1.Width, player1.Height))
)
            {
                player1.Top += step;
                gameModel.Player1.y = player1.Top;
                gameModel.Player1.Weight--;
            }

            player1Space = new Rectangle(player1.Left, player1.Top, player1.Width, player1.Height);
            player2Space = new Rectangle(player2.Left, player2.Top, player2.Width, player2.Height);



            if (
                IsIntersectionOverXPercent(player1Space, foodSpace, 50f) && food1.Eaten == false)
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
                MessageBox.Show(gameModel.Player1.Nick + " won");
                time = DateTime.Now - startTime;
                Close();
            }
            else if (FinishCondition(player1Space, player2Space) == 2)
            {
                MessageBox.Show(gameModel.Player2.Nick + " won");
                time = DateTime.Now - startTime;
                Close();
            }

            else if (FinishCondition(player1Space, player2Space) == 0)
            {

            }


        }

        private void PlayerInfo()
        {

           player1Info.Text = "Name: " + gameModel.Player1.Nick + "\nWeight: " + gameModel.Player1.Weight;
           player2Info.Text = "Name: " + gameModel.Player2.Nick + "\nWeight: " + gameModel.Player2.Weight;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            timeInfo.Text = "" + _ticks;

        }
        private int FinishCondition(Rectangle player1Space, Rectangle player2Space)
        {
            if (gameModel.Player1.Weight <= 0 || gameModel.Player2.Weight <= 0)
                return gameModel.Player1.Weight > gameModel.Player2.Weight ? 1 : 2;
            else
            {
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

        private void FoodGenerator()
        {
            Random random = new Random();
            int randNumber = random.Next(10, 60);

            if (randNumber % 5 == 0 && food1.Eaten == true)  //jeśli jedzonko zostało już zjedzone, to moze powstać nowe
            {
                food1.Eaten = false;
                food1.kg = randNumber;
                do
                {
                    food.Left = random.Next(innerRing.Left, innerRing.Right - food.Width);
                    food.Top = random.Next(innerRing.Top, innerRing.Bottom - food.Height);
                    food1.x = food.Left;
                    food1.y = food.Top;
                    foodSpace = new Rectangle(food.Left, food.Top, food.Width, food.Height);
                } while (checkCollision(foodSpace));
                
                food.Show();
            }

        }
        private bool checkCollision(Rectangle rect)
        {
            if (rect.IntersectsWith(obstacle1Space)) return true;
            else if (rect.IntersectsWith(obstacle2Space)) return true;
            else if (rect.IntersectsWith(obstacle3Space)) return true;
            else return false;


        }
        private void player1_Click(object sender, EventArgs e)
        {

        }
    }
}
