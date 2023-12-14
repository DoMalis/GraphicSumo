using SumoMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SumoMVC
{
    public partial class PlayForm : Form
    {
        Player playerFirst;
        Player playerSecond;

        private int _ticks; 
        public PlayForm(Player p1, Player p2)
        {
            InitializeComponent();
            playerFirst = p1;
            playerSecond = p2;
            _ticks = 0;
        }

      


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            player1.Location = new Point(playerFirst.x, playerFirst.y);
            player2.Location = new Point(playerSecond.x, playerSecond.y);

            //player1.Location = new Point(416,170);
            //player2.Location = new Point(440, 396);

            this.KeyDown += new KeyEventHandler(MovingWithoutObstacles);
            player1.Focus();
            player2.Focus();

        }
        public void MovingWithoutObstacles(object sender, KeyEventArgs e)
        {
            int step = 5; // Step size for character movement


            if (e.KeyCode == Keys.Left)
            {
                player2.Left -= step;
            }
            else if (e.KeyCode == Keys.Right)
            {
                player2.Left += step;
            }
            else if (e.KeyCode == Keys.Up)
            {
                player2.Top -= step;
            }
            else if (e.KeyCode == Keys.Down)
            {
                player2.Top += step;
            }
            else if (e.KeyCode == Keys.A)
            {
                player1.Left -= step;
            }
            else if (e.KeyCode == Keys.D)
            {
                player1.Left += step;
            }
            else if (e.KeyCode == Keys.W)
            {
                player1.Top -= step;
            }
            else if (e.KeyCode == Keys.S)
            {
                player1.Top += step;
        }
            //Rectangle Map = new Rectangle(0, 10, 30,20);
            Rectangle Map = new Rectangle(416, 170, 440, 396);
            Rectangle player1Space = new Rectangle(player1.Left, player1.Top, player1.Width, player1.Height);
            Rectangle player2Space = new Rectangle(player2.Left, player2.Top, player2.Width, player2.Height);
            /*Console.WriteLine($"X: {Map.X}");
            Console.WriteLine($"Y: {Map.Y}");
            Console.WriteLine($"Width: {Map.Width}");
            Console.WriteLine($"Height: {Map.Height}");
            Console.WriteLine($"XPlayer1: {player1Space.X}");
            Console.WriteLine($"YPlayer1: {player1Space.Y}");
            Console.WriteLine($"WidthPlayer1: {player1Space.Width}");
            Console.WriteLine($"HeightPlayer1: {player1Space.Height}");
            Console.WriteLine($"XPlayer2: {player2Space.X}");
            Console.WriteLine($"YPlayer2: {player2Space.Y}");
            Console.WriteLine($"WidthPlayer2: {player2Space.Width}");
            Console.WriteLine($"HeightPlayer2Player2: {player2Space.Height}");*/

            //to nizej nie działa 
            if (Map.IntersectsWith(player1Space))
            {
                player1.Location = new Point(player1.Left, player1.Top);
            }
            if (Map.IntersectsWith(player2Space))
            {
                player2.Location = new Point(player2.Left, player2.Top);
            }
        }


        public void DrawPlayer(Player player)
        {
            if (player.Id == 1)
            {
                player1.Location=new Point(player.x, player.y);
            }
            if (player.Id == 2)
            {
                player2.Location = new Point(player.x, player.y);
            }

            
        }

    }
}
