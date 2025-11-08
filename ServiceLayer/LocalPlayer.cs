using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class LocalPlayer
    {
        private readonly PlayerManager playerManager;
        private readonly GameManager gameManager;
        public LocalPlayer()
        {
            playerManager = new PlayerManager(new PlayerContext(new MinesweeperDbContext()));
            gameManager = new GameManager(new GameContext(new MinesweeperDbContext()));
            LoggedIn = false;
            Player = playerManager.Read(0);
            LocalGames = gameManager.ReadAll().Where(x => x.PlayerId == Player.Id).ToList();
            
        }
        public Player Player 
        {
            get;set;
        }

        public ICollection<Game> LocalGames { get; set; }
        public bool LoggedIn { get; set; }
        

        public void LogIn(string username, string password)
        {
            if(playerManager.ReadAll().Any(x => x!=null && x.Username == username && x.Password == password))
            {
                LoggedIn = true;
                Player = playerManager.ReadAll().FirstOrDefault(x => x.Username==username);
                LocalGames = gameManager.ReadAll().Where(x => x!=null && x.PlayerId == Player.Id).ToList();
            }
            else
            {
                throw new ArgumentException("Account does not exist!");

            }
        }
        public void LogOut()
        {
            LoggedIn = false;
            Player=playerManager.Read(0);
            LocalGames = gameManager.ReadAll().Where(x => x.PlayerId == Player.Id).ToList();
        }
        public void SignIn(string username, string password)
        {
            if(playerManager.ReadAll().Any(x => x.Username == username))
            {
                throw new ArgumentException("Username exists");
            }
            else
            {
                playerManager.Create(new Player(playerManager.AutoIncrement(), username, password));
            }
            
        }
    }
}
