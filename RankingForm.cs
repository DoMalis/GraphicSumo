using SumoMVC.Models;
using SumoMVC.Views;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SumoMVC
{
    public partial class RankingForm : Form
    {
        public RankingForm()
        {
            InitializeComponent();
            LoadRanking();
        }
        private void LoadRanking()
        {
            List<GameResult> gameResultsStandard = LoadGameResults("ranking.txt");

            List<GameResult> gameResultsStatic = LoadGameResults("rankingStatic.txt");

            List<GameResult> gameResultsRandom = LoadGameResults("rankingRandom.txt");

            ShowRanking(gameResultsStandard, gameResultsStatic, gameResultsRandom);
        }

        private List<GameResult> LoadGameResults(string filePath)
        {
            List<GameResult> gameResults = new List<GameResult>();
            if (File.Exists(filePath))
            {
                // Odczytujemy wszystkie linie z pliku rankingowego
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    // Dzielimy linię na nazwę gracza i wynik
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string playerName = parts[0];
                        int score = int.Parse(parts[1]);
                        string timeStr = parts[2];
                        TimeSpan gameTime = TimeSpan.Parse(timeStr);

                        Player player = new Player(playerName, 0);
                        player.Weight = score;

                        gameResults.Add(new GameResult(player, gameTime));
                    }
                }
            }
            return gameResults;
        }

        private void ShowRanking(List<GameResult> gameResultsStandard, List<GameResult> gameResultsStatic, List<GameResult> gameResultsRandom)
        {
            DisplayRanking(gameResultsStandard, listView1);
            DisplayRanking(gameResultsStatic, listView2);
            DisplayRanking(gameResultsRandom, listView3);
        }

        private void DisplayRanking(List<GameResult> gameResults, System.Windows.Forms.ListView listView)
        {
            listView.Clear();
            listView.View = View.Details;
            listView.Columns.Add("Name", 85);
            listView.Columns.Add("Score", 50);
            listView.Columns.Add("Time (sec)", 65);

            foreach (var result in gameResults)
            {
                ListViewItem item = new ListViewItem(result.PlayerName);
                item.SubItems.Add(result.Score.ToString());
                item.SubItems.Add(result.Time.TotalSeconds.ToString());
                listView.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
