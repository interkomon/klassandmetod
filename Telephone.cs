using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Telephone
    {
        public int DT;
        public double TT;
        public double TC;
        public double sum()
        {
            double fp = TT *TC;
            if (DT == 6 ||DT == 7)
                return fp -fp * 0.1;
            else return fp;
        }
    }
}
