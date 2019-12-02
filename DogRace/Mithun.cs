using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
    public static class Mithun
    {
        public static  int Mithunresult(int budget,int amount,int hint) {
            if (hint == 1)
            {
                return budget + amount;
            }
            else {
                return budget - amount;
            }
        }
    }
}
