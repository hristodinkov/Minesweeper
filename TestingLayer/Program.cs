using BusinessLayer;
using ServiceLayer;
using System.Threading.Channels;
using System;
using DataLayer;
using FireSharp.Response;
using Newtonsoft.Json;

namespace TestingLayer
{
    internal class Program
    {
        static void GridTest()
        {
            LocalGame currentGame = new LocalGame(DifficultySetting.Huge);
            for (int y = 0; y < currentGame.Length; y++)
            {
                for (int x = 0; x < currentGame.Width; x++)
                {
                    Console.Write(currentGame.Grid[y][x].ToString() + " |");
                }
                Console.WriteLine();
            }
        }
        static void GameOverTest()
        {
            LocalGame currentGame = new LocalGame(DifficultySetting.Huge);
            for (int y = 0; y < currentGame.Length; y++)
            {
                for (int x = 0; x < currentGame.Width; x++)
                {
                    if (currentGame.Grid[y][x].Value == 'b')
                    {
                        currentGame.Grid[y][x].IsDiscovered = true;
                        currentGame.Grid[y][x].GameOverCheck();
                    }
                }
            }
        }
        static void AdjacentCellsTest()
        {
            LocalGame currentGame = new LocalGame(DifficultySetting.Huge);
            for (int y = 0; y < currentGame.Length; y++)
            {
                for (int x = 0; x < currentGame.Width; x++)
                {
                    foreach (var item in currentGame.Grid[y][x].AdjacentCells)
                    {
                        Console.Write(item.ToString());
                    }
                    Console.WriteLine();
                }
            }
        }
        static void CreateTest()
        {
            MinesweeperDbContext db = new MinesweeperDbContext();
            GameContext gameContext = new GameContext(db);
            GameManager gameManager = new GameManager(gameContext);
            Game game = new Game(1, DifficultySetting.Hard, new TimeSpan(0,10, 48), 0);
            
            gameManager.Create(game);
            if (db.client != null)
            {
                Console.WriteLine("ti si pederas");
            }
        }
        static void WinGameTest()
        {
            LocalGame localGame = new LocalGame(DifficultySetting.Hard);
            LocalPlayer localPlayer = new LocalPlayer();
            localPlayer.Player = new Player(0, "pedalka2", "az");
            localGame.LocalPlayer = localPlayer; 
            
            localGame.Win();
            Console.WriteLine(localGame.Time);
        }
        static void FiresharpGetTest()
        {
            MinesweeperDbContext db = new MinesweeperDbContext();
            GameContext gameContext = new GameContext(db);
            PlayerContext playerContext = new PlayerContext(db);
            Player player = playerContext.Read(0);
            Console.WriteLine(player.Username);
        }
        static void FiresharpReadAllTest()
        {
            MinesweeperDbContext db = new MinesweeperDbContext();
            Dictionary<string, Player> dictionary = JsonConvert.DeserializeObject<Dictionary<string, Player>>(db.client.Get("Players/").Body.ToString());
            List<Player> players = dictionary.Values.ToList();
            foreach (var item in players)
            {
                Console.WriteLine(item.Id);
            }
        }
        static void CreatePlayerTest()
        {
            Player player = new Player(0, "Guest", "");
            PlayerManager playerManager = new PlayerManager(new PlayerContext(new MinesweeperDbContext()));
            playerManager.Create(player);
        }
        static void Main(string[] args)
        {
            FiresharpGetTest();
        }
    }
}