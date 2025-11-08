using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class WinScreen : Form
    {
        public LocalPlayer Player { get; set; }
        public WinScreen(Stopwatch stopwatch, LocalPlayer player)
        {
            InitializeComponent();
            Player = player;
            this.label3.Text = String.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (TheGame.ActiveForm != null)
                TheGame.ActiveForm.Close();
            DifficultySetting d1 = new DifficultySetting(Player);
            d1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (TheGame.ActiveForm != null)
                TheGame.ActiveForm.Close();
            MainMenu d1 = new MainMenu(Player);
            d1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
