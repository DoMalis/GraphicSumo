using SumoMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumoMVC
{
    public partial class EndForm : Form
    {
        IGameModel gameModel;     
            public EndForm(IGameModel gameModel)
        {
            InitializeComponent();
            this.gameModel = gameModel;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            string resultFilePath;
            // SaveGameResult(gameMode, player1.Nick, player1.Weight, gameTimer.Elapsed.TotalSeconds.ToString("F0"));
            // Ranking(gameMode);

            if (gameModel.Mode == 0)
            {
                resultFilePath = "ranking.txt";

            }
            else if (gameModel.Mode == 1)
            {
                resultFilePath = "rankingStatic.txt";

            }
            else
            {
                resultFilePath = "rankingRandom.txt";

            }
            using (StreamWriter writer = new StreamWriter(resultFilePath, true))
            {

                writer.WriteLine(gameModel.GameResult.PlayerName + "," + gameModel.GameResult.Score + "," + gameModel.GameResult.Time.ToString(@"hh\:mm\:ss"));
            }
            this.Hide();
            

        }
    }
}
