using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Profiles : Form
    {
        public LocalPlayer Player { get; set; }
        public Profiles(LocalPlayer player)
        {
            Player = player;
            InitializeComponent();
            label2.Text = Player.Player.Username;
        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_In log = new Log_In(Player);
            log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu(Player);
            menu.Show();
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up sign = new Sign_up(Player);
            sign.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Player.LogOut();
            MessageBox.Show("You have logged out successfully", "You logged out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            MainMenu menu = new MainMenu(Player);
            menu.Show();
        }

        private void Profiles_Load(object sender, EventArgs e)
        {

        }
    }
}
