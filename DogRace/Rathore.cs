using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
   public static  class Rathore
    {
        public static int Rathoreresult(int budget, int amount, int hint)
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
