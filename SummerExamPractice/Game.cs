using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerExamPractice
{
    public class Game
    {
        public int GameID { get; set; }
        public string Name { get; set; }

        public int MetacriticScore  { get; set; }

        public string Description { get; set; }

        public string Platform { get; set; }

        public decimal Price { get; set; }

        public string Game_Image { get; set; }

        public void DecreasePrice(decimal discount)
        {
            Price -= discount;
        }
    }

    public class GameData:DbContext
    {
        public GameData() : base("GameDataDB") { }

        public DbSet<Game> Games { get; set; }
    }
}
