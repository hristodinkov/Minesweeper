using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class Leaderboard
    {
        private static readonly GameManager gameManager = new GameManager(new GameContext(new MinesweeperDbContext()));
        private static readonly PlayerManager playerManager = new PlayerManager(new PlayerContext(new MinesweeperDbContext()));
        public static Dictionary<Game, Player> OrderedGames
        {
            get
            {
                Dictionary<Game, Player> orderedGames = new Dictionary<Game, Player>();

                List<Game> games = gameManager.ReadAll().OrderBy(x => x.Time).ToList();
                foreach(var game in games)
                {
                    orderedGames.Add(game, playerManager.Read(game.PlayerId));
                }
                return orderedGames;
            } 
        }
        public static Dictionary<Game,Player> FilterByDifficulty(int difficulty)
        {
            return OrderedGames.Where(x => (int)x.Key.Difficulty == difficulty).ToDictionary(x => x.Key, x => x.Value);
        }
        public static Dictionary<Game, Player> FilterByDifficultyAndUsername(int difficulty, string Username)
        {
            if(OrderedGames.Values.Any(x=>x.Username==Username))
            {
                return OrderedGames.Where(x => (int)x.Key.Difficulty == difficulty && x.Value.Username == Username).ToDictionary(x => x.Key, x => x.Value);
            }
            else
            {
                return FilterByDifficulty(difficulty);
            }
            
        }
    }
}
