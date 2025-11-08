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
    public partial class GameLostScreen : Form
    {
        public int Difficulty { get; set; }
        public LocalGame Game { get; set; }
        public LocalPlayer Player { get; set; }
        public GameLostScreen(int difficulty, LocalPlayer player)
        {
            Player = player;
            InitializeComponent();
            Difficulty = difficulty;
        }
        public GameLostScreen(LocalGame game, LocalPlayer player)
        {
            Player = player;
            InitializeComponent();
            Game = game;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainMenu_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            if(TheGame.ActiveForm!=null) TheGame.ActiveForm.Close();

            MainMenu m1 = new MainMenu(Player);
            m1.Show();
        }

        private void retry_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (TheGame.ActiveForm != null) TheGame.ActiveForm.Close();
            LocalGame game = new LocalGame(Game.Length, Game.Width, Game.Bombs);
            game.Difficulty = Game.Difficulty;
            TheGame g1 = new TheGame(game, Player);
            g1.Show();
        }

        private void GameLostScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
