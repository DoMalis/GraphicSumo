﻿using SumoMVC.Controllers;
using SumoMVC.Models;
using SumoMVC.Views;
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //this.Hide();
            IGameView gV= new GameView();
            IGameModel gM=new GameModel();
            GameController gC = new GameController(gV,gM);

            //gM.Player1 = new Player("asia", 1);
            //gM.Player2 = new Player("basia", 2);

            //PlayObstacleForm playObstacleForm = new PlayObstacleForm(gM);
            //playObstacleForm.ShowDialog();

            gC.StartGame();

            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tworzenie instancji AboutForm
            AboutForm aboutForm = new AboutForm();

            // Wywołanie formularza AboutForm
            aboutForm.Show();

            // ukrywanie bieżącego formularza MenuForm
            //this.Hide();

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            ExitForm exitForm = new ExitForm();
            exitForm.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RankingForm rankingForm = new RankingForm();
            rankingForm.Show();
            //this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
