using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonacciNumber
{
    class FibbonacciNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            int firstNumb = 1, secondNumb = 1, numberTemp = 0;
            StringBuilder stringb = new StringBuilder();

            for (int i = 0; i <n; i++)

            {
                numberTemp = firstNumb;
                firstNumb = secondNumb;
                secondNumb += numberTemp;
                stringb.Append(numberTemp);

            }
            Console.WriteLine(stringb);
        }
    }
}
