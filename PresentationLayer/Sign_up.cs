using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer;


namespace PresentationLayer
{
    public partial class Sign_up : Form
    {
        public LocalPlayer Player { get; set; }
        public bool UsernameClick { get; set; }
        public bool PasswordClick { get; set; }
        public Sign_up(LocalPlayer Player)
        {
            this.Player = Player;
            UsernameClick = false;
            PasswordClick = false;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!UsernameClick)
            {
                TextBox textBox1 = sender as TextBox;
                textBox1.Text = String.Empty;
                UsernameClick = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!PasswordClick)
            {
                TextBox textBox2 = sender as TextBox;
                textBox2.Text = String.Empty;
                PasswordClick = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profiles profiles = new Profiles(Player);
            profiles.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Player.SignIn(textBox1.Text, textBox2.Text);
                Player.LogIn(textBox1.Text, textBox2.Text);
                MessageBox.Show("You have signed up successfully", "You signed up!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu profiles = new MainMenu(Player);
                this.Hide();
                profiles.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("User already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Sign_up_Load_1(object sender, EventArgs e)
        {

        }
    }
}
