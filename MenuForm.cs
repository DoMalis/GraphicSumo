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

            IGameView gV= new GameView();
            IGameModel gM=new GameModel();
            GameController gC = new GameController(gV,gM);

            gC.StartGame();

            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tworzenie instancji AboutForm
            AboutForm aboutForm = new AboutForm();

            // Wywołanie formularza AboutForm
            aboutForm.Show();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            ExitForm exitForm = new ExitForm();
            exitForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RankingForm rankingForm = new RankingForm();
            rankingForm.Show();
        }
    }
}
