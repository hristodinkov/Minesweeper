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
using ServiceLayer;

namespace PresentationLayer
{
    public partial class TheGame : Form
    {
        public LocalGame Game{ get; set; }
        public LocalPlayer Player { get; set; }
        public int Difficulty { get; set; }
        public Dictionary<Button,Cell> Buttons { get; set; }
        public Cell[][] Minefield { get; set; }
        public Stopwatch Stopwatch { get; set; }
        private Stopwatch stopwatch;
        public int Bombs { get; set; }
        public bool GameEnd { get; set; }
        public TheGame(int difficulty, LocalPlayer player)
        {
            Buttons = new Dictionary<Button, Cell>();
            Player = player;
            this.Difficulty = difficulty; 
            InitializeComponent();
            Game=new LocalGame(Difficulty);
            this.GameEnd= false;
            StartGame(difficulty);
            Game.WinEvent += Win;
            Game.LocalPlayer = Player;
            Game.StartGame();
        }
        public TheGame(LocalGame game, LocalPlayer player)
        {
            Buttons = new Dictionary<Button, Cell>();
            Player=player;
            this.Difficulty = (int)game.Difficulty;
            InitializeComponent();
            this.GameEnd = false;
            Game = game;
            Game.WinEvent += Win;
            Game.LocalPlayer = Player;
            Game.StartGame();
            StartGame(Difficulty);
        }
        public void StartGame(int difficulty)
        {
            Minefield = Game.Grid;
            Bombs = Game.Bombs;
            bomb_lbl.Text = Bombs.ToString();
            GenerateMinefield(Minefield);
        }
        public void GenerateMinefield(Cell [][] minefieldGrid)
        {
            
            minefieldTable.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            minefieldTable.AutoSize = true;

            int InsertRowNum = Game.Length;
            int InsertColumnNum = Game.Width;
            minefieldTable.RowCount = InsertRowNum;
            minefieldTable.ColumnCount = InsertColumnNum;
            minefieldTable.AutoScroll = true;
            minefieldTable.Visible = true;

            int winformWidth = this.Size.Width;
            int winformHeight = this.Size.Height;
            for (int i = 0; i < InsertRowNum; i++)
            {
                for (int j = 0; j < InsertColumnNum; j++)
                {
                    Button button = new Button();
                    button.Height= winformWidth * 11/100;
                    button.Width = winformWidth * 11/100;
                    button.BackColor = Color.SeaShell;
                    button.ForeColor = Color.SeaShell;
                    Cell cell = minefieldGrid[i][j];
                    button.MouseUp += (s, e) => btn_Click(s, e,cell, button);
                    SetButtonValue(button, j, i, minefieldGrid);
                    minefieldTable.Controls.Add(button, j, i);
                    cell.RaiseGameOver += (s, e) => GameOver(s, e, button);
                    cell.RaiseGameOver += (s,e) => Reveal(s, e, button);
                    Buttons.Add(button,cell);
                }
            }

            minefieldTable.Visible = true;
        }
        private void SetButtonValue(Button button,int j, int i,Cell[][] minefield_button)
        {
            char value = minefield_button[i][j].Value;
            button.Text = value != '0' ? value.ToString() : " ";
        }
        private void Reveal(object sender,EventArgs e,Button button)
        {
            foreach (var item in Buttons)
            {

                if (item.Value.Value=='b')
                {
                    item.Key.BackColor = Color.Black;
                    item.Key.ForeColor = Color.Black;   
                }

            }
        }
        private void GameOver(object sender,EventArgs e,Button button)
        {
            stopwatch.Stop();
            GameEnd = true;
            button.BackColor = Color.Black;
            button.ForeColor = Color.Black;           
            GameLostScreen gl1 = new GameLostScreen(Game,Player);
            gl1.Show();
        }
        private void Win (object sender, EventArgs e)
        {
            stopwatch.Stop ();
            GameEnd = true;
            WinScreen w = new WinScreen(this.stopwatch,Player);
            w.Show();
        }
        private void btn_Click (object sender, MouseEventArgs e, Cell c, Button button)
        {
            if (c.IsDiscovered||GameEnd)
            {
                return;
            }
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (c.IsFlagged)
                    {
                        return;
                    }
                    Game.Discover(c.PositionX, c.PositionY);
                    foreach (var item in Buttons)
                    {

                        if (item.Value.IsDiscovered)
                        {
                            item.Key.BackColor = item.Value.Value != 'b' ? Color.LightSlateGray : Color.Black;
                        }
                        
                    }
                    break;
                case MouseButtons.Right:
                    Game.Flag(c.PositionX, c.PositionY);
                    if (Minefield[c.PositionY][c.PositionX].IsFlagged)
                    {
                        button.BackColor=Color.IndianRed;
                        button.ForeColor = Color.IndianRed;
                        Bombs--;
                        bomb_lbl.Text =Bombs.ToString();
                    }
                    else
                    {
                        button.BackColor=Color.SeaShell; 
                        button.ForeColor=Color.SeaShell;
                        Bombs++;
                        bomb_lbl.Text=Bombs.ToString();
                    }                    
                    break;                    
            }
        }
        private void FormAutoResolution_Load(object sender, EventArgs e)
        {
            // Scale our form to look like it did when we designed it.
            // This adjusts between the screen resolution of the design computer and the workstation.
            int ourScreenWidth = Screen.FromControl(this).WorkingArea.Width;
            int ourScreenHeight = Screen.FromControl(this).WorkingArea.Height;
            float scaleFactorWidth = (float)ourScreenWidth / 1600f;
            float scaleFactorHeigth = (float)ourScreenHeight / 900f;
            SizeF scaleFactor = new SizeF(scaleFactorWidth, scaleFactorHeigth);
            Scale(scaleFactor);

            // If you want to center the resized screen.
            CenterToScreen();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TheGame_Load(object sender, EventArgs e)
        {
            
            stopwatch = new Stopwatch();
            stopwatch.Start();
            //bomb_lbl_TextChanged();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = String.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

        private void bomb_lbl_Click(object sender, EventArgs e)
        {

        }

        private void bomb_lbl_TextChanged(object sender, EventArgs e)
        {
            this.bomb_lbl.Text=Bombs.ToString();
        }
    }
}
