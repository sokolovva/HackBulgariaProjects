using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergerPolindrome
{
    class IntegerPolindrome
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            string numberString = number.ToString();

            Console.Write("Is palindrome? ");
            Console.WriteLine(IsPolidrome(numberString));
            nextSmaller(number);



        }
        private static bool IsPolidrome(int number)
        {

            string num = number.ToString();
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        private static void nextSmaller(int number)
        {
            if (isPolindrom(number))
            {
                Console.WriteLine(number);
            }
            else
            {
                for (int i = number; i >= 0; i--)
                {
                    isPolindrom(i);
                    if (isPolindrom(i))
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }

            }
         }
        }
}
