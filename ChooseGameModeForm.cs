﻿using System;
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
    public partial class ChooseGameModeForm : Form
    {
        public int Mode{ get; private set; }

        public ChooseGameModeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mode = 0;
            DialogResult = DialogResult.OK;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mode = 1;
            DialogResult = DialogResult.OK;

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mode = 2;
            DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
