using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGame
{
    public class Round
    {
        public List<int> Areas { get; set; }
        public List<int> Multipliers { get; set; }

        public Round()
        {
            Areas = new List<int>();
            Multipliers = new List<int>();
        }
    }
}
