using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        

        static void Main(string[] args)
        {
            Console.Write("enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0 || number == 1)
            {
                Console.WriteLine(number + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= number / 2; a++)
                {
                    if (number % a == 0)
                    {
                        Console.WriteLine(number + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(number + " is a prime number");
                Console.ReadLine();
            }
        }
    }
}
