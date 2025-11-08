using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml;
using ServiceLayer;

namespace PresentationLayer
{
    public partial class Log_In : Form
    {
        public LocalPlayer Player { get; set; }
        public bool NicknameCLicked { get; set; }
        public bool PasswordClicked { get; set; }
        public Log_In(LocalPlayer Player)
        {
            this.Player = Player;
            NicknameCLicked = false;
            PasswordClicked = false;
            InitializeComponent();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!NicknameCLicked)
            {
                TextBox textBox1 = sender as TextBox;
                textBox1.Text = String.Empty;
                NicknameCLicked = true;
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {

            if (!PasswordClicked)
            {
                TextBox textBox2 = sender as TextBox;
                textBox2.Text = String.Empty;
                PasswordClicked = true;
            }
        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Player.LogIn(textBox1.Text, textBox2.Text);
                MessageBox.Show("You have logged in successfully", "You logged in!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainMenu menu = new MainMenu(Player);
                menu.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profiles p = new Profiles(Player);
            p.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
