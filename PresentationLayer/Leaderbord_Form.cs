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
    public partial class Leaderbord_Form : Form
    {
        public LocalPlayer Player { get; set; }
        public int Difficulty { get; set; }
        public string Username { get; set; }
        public Leaderbord_Form(LocalPlayer player)
        {
            Player = player;
            InitializeComponent();
            dataGridView1.Columns.Add("Username", "Username");
            dataGridView1.Columns.Add("Time", "Time");
            dataGridView1.Columns.Add("Difficulty", "Difficulty");
            comboBox1.Items.AddRange(new object[] { "Easy", "Medium", "Hard", "Huge", "Expert", "Custom" });
            comboBox1.SelectedIndex = 0;
            LoadLeaderboard();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadLeaderboard(int difficulty = 0, string username = null)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in Leaderboard.FilterByDifficultyAndUsername(difficulty, username))
            {
                dataGridView1.Rows.Add(new object[] { item.Value.Username, item.Key.Time, item.Key.Difficulty });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu(Player);
            mainMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadLeaderboard(Difficulty, Username);
        }

        private void Leaderbord_Form_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Difficulty = comboBox1.SelectedIndex;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Username = textBox1.Text;
        }
    }
}
