using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerExamPractice
{
    class Game
    {
        public string Name { get; set; }

        public int MetacriticScore  { get; set; }

        public string Description { get; set; }

        public string Platform { get; set; }

        public decimal Price { get; set; }

        public string Game_Image { get; set; }

        public int DecreasePrice(int discount)
        {
            Price -= discount;
        }
    }
}
