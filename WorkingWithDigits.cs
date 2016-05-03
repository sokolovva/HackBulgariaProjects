using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WorkingWithDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            CountDigits(n);
            SumDigits(n);
            FactorialDigits(n);

            
        }
        private static void CountDigits (int n)
        {
            int digits = 0;
            while (n > 0)
            {
                digits++;
                n /= 10;
            }
            Console.WriteLine("The count of digits is {0}", digits);
        }

        private static void SumDigits (int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("The sum of digits is: {0}", sum);
        }
        
        private static void FactorialDigits(int n)
        {
            int sum = 0;
          
            char[] charArr = n.ToString().ToCharArray();
            int[] intArr = new int[charArr.Length];
            for (int i = 0; i < charArr.Length; i++)
            {
                intArr[i] = int.Parse(charArr[i].ToString());
            }
           
            for (int i = 0; i < intArr.Length; i++)
            {
                int factorial = 1;
                for (int j = intArr[i]; j > 1; j--)
                {

                    factorial = factorial * j;
                }
                sum = sum + factorial;
            }
            Console.WriteLine(sum);
        }
        
    }
}
