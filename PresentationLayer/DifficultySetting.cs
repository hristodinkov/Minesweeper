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
    public partial class DifficultySetting : Form
    {
        public LocalPlayer Player { get; set; }
        public DifficultySetting(LocalPlayer player)
        {
            InitializeComponent();
            Player = player;
        }
        public int Difficulty { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }
        public int Bombs { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void custom_lbl_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (bombs_counter.Value <= 1)
            {
                bombs_counter.Value = 1;
            }
        }

        private void easy_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Difficulty = 0;
            TheGame g1 = new TheGame(Difficulty, Player);
            g1.Show();
        }

        private void medium_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Difficulty = 1;
            TheGame g1 = new TheGame(Difficulty, Player);
            g1.Show();
        }

        private void hard_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Difficulty = 2;
            TheGame g1 = new TheGame(Difficulty, Player);
            g1.Show();
        }

        private void huge_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Difficulty = 3;
            TheGame g1 = new TheGame(Difficulty, Player);
            g1.Show();
        }

        private void extreme_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Difficulty = 4;
            TheGame g1 = new TheGame(Difficulty, Player);
            g1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rows = (int)x_square.Value;
            Cols = (int)y_squares.Value;
            Bombs = (int)bombs_counter.Value;
            Difficulty = 5;
            LocalGame game = new LocalGame(Rows, Cols, Bombs);
            TheGame game1 = new TheGame(game, Player);
            game1.Show();
        }

        private void x_square_ValueChanged(object sender, EventArgs e)
        {
            if (x_square.Value <= 1)
            {
                x_square.Value = 1;
            }
            bombs_counter.Maximum = x_square.Value * y_squares.Value;
        }

        private void y_squares_ValueChanged(object sender, EventArgs e)
        {
            if (y_squares.Value <= 1)
            {
                y_squares.Value = 1;
            }
            bombs_counter.Maximum = x_square.Value * y_squares.Value;
        }

        private void DifficultySetting_Load(object sender, EventArgs e)
        {

        }
    }
}
