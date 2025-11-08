using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class PlayerManager : IManager<Player, int> // za dovurshvane
    {
        private readonly PlayerContext playerContext;
        public PlayerManager(PlayerContext playerContext)
        {
            this.playerContext = playerContext;
        }
        public void Create(Player item)
        {
            try
            {
                item.Id = AutoIncrement();
                playerContext.Create(item);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int AutoIncrement()
        {
            if (ReadAll() != null)
            {
                List<Player> players = ReadAll().ToList();
                return ReadAll().Max(x => x.Id) + 1;
            }
            else
            {
                return 0;
            }

        }

        public void Delete(int key)
        {
            try
            {
                playerContext.Delete(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Player Read(int key)
        {
            try
            {
                return playerContext.Read(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public ICollection<Player> ReadAll()
        {
            try
            {
                return playerContext.ReadAll();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Update(Player item)
        {
            try
            {
                playerContext.Update(item);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }
}
