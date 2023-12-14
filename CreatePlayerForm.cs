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
    public partial class CreatePlayerForm : Form
    {
        public string PlayerName { get; private set; }
        public int PlayerId { get; private set; }

        public CreatePlayerForm(int playerId)
        {
            InitializeComponent();
            PlayerId = playerId;

        }

        private void CreatePlayerForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Enter a name for player number " + PlayerId.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerName = textBox1.Text;
            if (string.IsNullOrEmpty(PlayerName))
            {
                MessageBox.Show("Please enter a valid player name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK; // Zwróć OK, gdy gracz utworzy nazwę
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
