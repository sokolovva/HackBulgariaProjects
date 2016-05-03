using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Lucas(n));
        }
        private static int Lucas(int n)
        {
            if (n == 0)
            {
                return 2;
            }
            if (n == 1)
            {
                return 1;
        }
            return Lucas(n - 1) + Lucas(n-2);
        }
    }
   
}
