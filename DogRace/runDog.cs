using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
    public static class runDog
    {
        public static Random instance_No = new Random();
        public static int genNo = 0;
        public static int generateNo() {
            genNo = instance_No.Next(1,30);
            return genNo;
        }
    }
}
