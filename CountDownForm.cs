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
    public partial class CountDownForm : Form
    {

        private int countdownValue;
        private string start = "START";
        public CountDownForm()
        {
            InitializeComponent();
            countdownValue = 3;
            label1.Text = countdownValue.ToString();
            countdownValue = 2;

            InitializeCountdownTimer();
        }


        private void InitializeCountdownTimer()
        {
            Timer countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second interval
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
        }

        private async void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (countdownValue >=1)
            {
                if (countdownValue != 0) 
                    UpdateCountdownLabel();
                countdownValue--;

            }
            else
            {
                label1.Text = start;
                ((Timer)sender).Stop();
                await Task.Delay(1000);
                DialogResult = DialogResult.OK;
                Close();
               
            }

        }

        private void UpdateCountdownLabel()
        {
            if (countdownValue >= 1)
                label1.Text = countdownValue.ToString();
           
        }
    }
}
