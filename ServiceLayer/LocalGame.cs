using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ServiceLayer
{
    public class LocalGame
    {

        public LocalGame(int length, int width, int bombs)
        {
            this.Length = length;
            this.Width = width;
            this.InitialBombs = bombs;
            this.Bombs = bombs;
            Timer = new Stopwatch();
            Difficulty = DifficultySetting.Custom;
            LocalPlayer = new LocalPlayer();
            GenerateGrid();
        }
        public LocalGame(DifficultySetting difficulty)
        {
            Difficulty = difficulty;
            EvaluateDifficulty(Difficulty);
            InitialBombs = Bombs;
            Timer = new Stopwatch();
            LocalPlayer=  new LocalPlayer();
            GenerateGrid();
        }
        public LocalGame(int difficulty)
        {
            Difficulty = (DifficultySetting)difficulty;
            EvaluateDifficulty(Difficulty);
            InitialBombs = Bombs;
            Timer = new Stopwatch();
            LocalPlayer = new LocalPlayer();
            GenerateGrid();
        }
        public DifficultySetting Difficulty { get; set; }
        public int InitialBombs { get; set; }
        public int Bombs { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public Stopwatch Timer { get; set; } //stoinostta se zapazva v promenliva ot tip TimeSpan
        public TimeSpan Time { get; set; }
        public LocalPlayer LocalPlayer { get; set; }
        public Cell[][] Grid { get; set; }
        public event EventHandler<EventArgs> WinEvent;
       private readonly GameManager GameManager = new GameManager(new GameContext(new MinesweeperDbContext()));
        private readonly PlayerManager PlayerManager = new PlayerManager(new PlayerContext(new MinesweeperDbContext()));
        public void StartGame()
        {
            Timer.Start();
        }
       
        public void GameOver(object sender, EventArgs e)
        {         
            EndGame();
            Timer.Reset();
        }
        public void Win()
        {
            EndGame();
            Time = Timer.Elapsed;
            GameManager.Create(new Game(GameManager.AutoIncrement(), Difficulty, Time, LocalPlayer.Player.Id));
            Timer.Reset();
        }
        public void SetPlayer(int id)
        {
            LocalPlayer.Player = PlayerManager.Read(id);
        }
        public void Flag(int x, int y)
        {
            bool flag = !Grid[y][x].IsFlagged;
            Grid[y][x].IsFlagged = flag;
            if (flag == true)
            {
                Bombs--;
            }
            else
            {
                Bombs++;
            }
            WinCheck();
        }
        public void Discover(int x, int y)
        {
            Grid[y][x].IsDiscovered = true;
            Grid[y][x].GameOverCheck();
            if (Grid[y][x].Value =='0')
            {
                foreach(Cell cell in Grid[y][x].AdjacentCells.Where(x => x.Value != 'b' && !x.IsDiscovered))
                {
                    Discover(cell.PositionX, cell.PositionY);
                }
            }
            WinCheck();
        }
        public void WinCheck()
        {
            if (Bombs == 0)
            {
                for (int y = 0; y < Length; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        Cell cell = Grid[y][x];
                        if (cell.Value == 'b' && !cell.IsFlagged)
                        {
                            return;
                        }
                        if (cell.Value != 'b' && !cell.IsDiscovered)
                        {
                            return;
                        }
                    }
                }
                EventHandler<EventArgs> raiseEvent = WinEvent;
                if (raiseEvent != null)
                {
                    raiseEvent(this, new EventArgs());
                }
                Win();
            }
            
        }
        public void EndGame()
        {
            Timer.Stop();
            Bombs = InitialBombs;
        }
        
        private void GenerateGrid()
        {
            
            InitializeGrid();
            PlaceBombs();
            AssignCellValues();
        }
        private void InitializeGrid()
        {
            Grid = new Cell[Length][];
            for (int y = 0; y < Length; y++)
            {
                Grid[y] = new Cell[Width];
                for (int x = 0; x < Width; x++)
                {
                    Grid[y][x] = new Cell(x,y);
                    Grid[y][x].RaiseGameOver += GameOver;
                }
            }
        }
        private void PlaceBombs()
        {
            int bombsLeft = Bombs;
            Random random = new Random();
            double chance = (double)Bombs * 100 / (double)(Length * Width);
            int number;
            do
            {
                for (int y = 0; y < Length; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        number = random.Next(0, 100);
                        if (number < chance && Grid[y][x].Value != 'b')
                        {
                            Grid[y][x].Value = 'b';
                            bombsLeft--;
                            if (bombsLeft == 0) return;
                        }
                    }
                }
            }
            while (bombsLeft != 0);
        }
        
        private void AssignCellValues()
        {
            for (int y = 0; y < Length; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (Grid[y][x].Value != 'b')
                    {
                        for (int i = y - 1; i <= y + 1; i++)
                        {
                            for (int j = x - 1; j <= x + 1; j++)
                            {
                                if (i >= 0 && j >= 0 && (i != y || j != x) && i < Length && j < Width)
                                {
                                    Grid[y][x].AdjacentCells.Add(Grid[i][j]);
                                }
                            }
                        }
                        Grid[y][x].CalculateValue();
                    }                 
                }
            }
        }
        private void EvaluateDifficulty(DifficultySetting difficulty)
        {
            switch (Difficulty)
            {
                case (DifficultySetting.Easy):
                    {
                        Length = 9;
                        Width = 9;
                        Bombs = 10;
                        break;
                    }
                case (DifficultySetting.Medium):
                    {
                        Length = 16;
                        Width = 16;
                        Bombs = 40;
                        break;
                    }
                case (DifficultySetting.Hard):
                    {
                        Length = 16;
                        Width = 30;
                        Bombs = 99;
                        break;
                    }
                case (DifficultySetting.Huge):
                    {
                        Length = 27;
                        Width = 48;
                        Bombs = 150;
                        break;
                    }
                case (DifficultySetting.Extreme):
                    {
                        Length = 18;
                        Width = 32;
                        Bombs = 150;
                        break;
                    }
            }
        }
    }
}
