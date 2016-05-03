using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class FactorialRecursive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n: ");
            int n = int.Parse(Console.ReadLine());
            Fact(n);
            
            
               
        }
        private static int Fact(int n)
        {
           if (n <=1)
                {
                return 1;
            }
            return n * Fact(n - 1);

        }
    }
}
