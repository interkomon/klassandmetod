using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SquareCycle
    {   
        public void povtor()
        {
            int sq;
            for (int i = 1; i < 10; i++)
            {
                sq = (int)Math.Pow(i, 2);
                Console.WriteLine(i);
                StopCycle pr = new StopCycle();
                pr.publish(sq);
            }
        }
    }
}
