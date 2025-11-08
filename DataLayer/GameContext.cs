using BusinessLayer;
using Newtonsoft.Json;

namespace DataLayer
{
    public class GameContext : IDb<Game, int>//da sa naprai crud i po natatuka nqkuv nachin za sortirane i filtrirane po difficulty i igrach
    {
        private readonly MinesweeperDbContext dbContext;

        public GameContext(MinesweeperDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Game item)
        {
            try
            {
                dbContext.client.Set("Games/" + item.Id, item);
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
                dbContext.client.Delete("Games/" + key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Game Read(int key)
        {
            try
            {
                return dbContext.client.Get("Games/" + key).ResultAs<Game>();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ICollection<Game> ReadAll()
        {
            try
            {
                try
                {
                    MinesweeperDbContext db = new MinesweeperDbContext();

                    Dictionary<string, Game> dict = JsonConvert.DeserializeObject<Dictionary<string, Game>>(db.client.Get("Games/").Body.ToString());

                    List<Game> games = dict.Values.ToList();
                    return games.Where(x => x != null).ToList();
                }
                catch (Exception)
                {

                    MinesweeperDbContext db = new MinesweeperDbContext();

                    List<Game> dict = JsonConvert.DeserializeObject<List<Game>>(db.client.Get("Games/").Body.ToString());

                    List<Game> games = dict.ToList();
                    return games.Where(x => x != null).ToList();
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Game item)
        {
            try
            {
                dbContext.client.Update("Games/" + item.Id, item);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}