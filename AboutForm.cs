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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MenuForm menuForm = new MenuForm();
            //menuForm.Show();
            this.Close();

        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
