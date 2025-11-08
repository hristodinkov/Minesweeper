using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PlayerContext : IDb<Player, int> // da sa naprai crud
    {
        private readonly MinesweeperDbContext dbContext;

        public PlayerContext(MinesweeperDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Player item)
        {
            try
            {
                dbContext.client.Set("Players/" + item.Id, item);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int key)
        {
            try
            {
                dbContext.client.Delete("Players/" + key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Player Read(int key)
        {
            try
            {
                return dbContext.client.Get("Players/" + key).ResultAs<Player>();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public ICollection<Player> ReadAll()
        {
            try
            {
                try
                {
                    MinesweeperDbContext db = new MinesweeperDbContext();
                    List<Player> players = JsonConvert.DeserializeObject<List<Player>>(db.client.Get("Players/").Body.ToString());
                    return players.Where(x => x != null).ToList();
                }
                catch (Exception)
                {

                    MinesweeperDbContext db = new MinesweeperDbContext();
                    Dictionary<string, Player> players = JsonConvert.DeserializeObject<Dictionary<string, Player>>(db.client.Get("Players/").Body.ToString());
                    return players.Values.Where(x=> x!=null).ToList();
                }          
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Player item)
        {
            try
            {
                dbContext.client.Update("Players/" + item.Id, item);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
