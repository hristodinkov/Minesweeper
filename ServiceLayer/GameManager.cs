using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public class GameManager : IManager<Game, int> //za dovurshvane
    {
        private readonly GameContext gameContext;
        public GameManager(GameContext gameContext)
        {
            this.gameContext = gameContext;
        }
        public void Create(Game item)
        {
            try
            {
                item.Id = AutoIncrement();
                gameContext.Create(item);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Delete(int key)
        {
            try
            {
                gameContext.Delete(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Game Read(int key)
        {
            try
            {
                return gameContext.Read(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public ICollection<Game> ReadAll()
        {
            try
            {
                return gameContext.ReadAll(); 
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Update(Game item)
        {
            try
            {
                gameContext.Update(item);
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
                return ReadAll().Max(x => x.Id) + 1;
            }
            else
            {
                return 0;
            }

        }
    }
}