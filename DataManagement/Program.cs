using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerExamPractice;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            GameData db = new GameData();

            using(db)
            {
                Game g1 = new Game()
                {
                    Name = "Call of Duty",
                    Platform = "Xbox",
                    MetacriticScore = 75,
                    Price = 60m,
                    Game_Image = "/images/COD.jpg",
                    Description = "Call of duty shoot shoot bang bang"
                };
                Game g2 = new Game()
                {
                    Name = "Call of Juarez",
                    Platform = "PC",
                    MetacriticScore = 50,
                    Price = 30m,
                    Game_Image = "/images/COJ.jpg",
                    Description = "Call of Juarez shoot shoot bang bang"
                };
                Game g3 = new Game()
                {
                    Name = "Fall guys",
                    Platform = "Playstation",
                    MetacriticScore = 99,
                    Price = 20m,
                    Game_Image = "/images/fg.jpg",
                    Description = "Beans do total wipeout. Last man standing wins"
                };
                Game g4 = new Game()
                {
                    Name = "Destiny",
                    Platform = "Switch",
                    MetacriticScore = 66,
                    Price = 60m,
                    Game_Image = "/images/destiny.jpg",
                    Description = "Destiny is halo but not halo and expansions cost more than the game"
                };

                Console.WriteLine("Games have been created");

                db.Games.Add(g1);
                db.Games.Add(g2);
                db.Games.Add(g3);
                db.Games.Add(g4);

                Console.WriteLine("Added Games");

                db.SaveChanges();
                Console.WriteLine("Data saved. Press any button to continue");
                Console.ReadLine();
            }
        }
    }
}
