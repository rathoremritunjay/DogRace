using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
    public static class Jatinder
    {

        public static int Jatinderresult(int budget, int amount, int hint)
        {
            if (hint == 1)
            {
                return budget + amount;
            }
            else
            {
                return budget - amount;
            }
        }
    }
}
