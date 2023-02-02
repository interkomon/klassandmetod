using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {

                Telephone telephone = new Telephone();
                do
                {
                    Console.WriteLine("Какой день разговора, от 1 до 7 ");
                    telephone.DT = Convert.ToInt32(Console.ReadLine());
                    if (telephone.DT > 7 || telephone.DT < 1) Console.WriteLine("Попробуйте еще раз");
                } while (telephone.DT > 7 || telephone.DT < 1);
                Console.WriteLine("время ");
                telephone.TT = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("стоимость");
                telephone.TC = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"конечная стоимость {telephone.sum()}");

              
                SquareCycle cycle = new SquareCycle();
                cycle.povtor();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
            

            Console.ReadKey();
        }
    }
}
