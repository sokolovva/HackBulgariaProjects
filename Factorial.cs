using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackBulgaria
{
    class Factorial
    {
        static void Main()
        {

            int factorial=1;
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >1 ; i--)
            {

                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
            
          

        }

    }
}
