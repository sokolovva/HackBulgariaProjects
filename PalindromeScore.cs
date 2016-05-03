using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeScore
{
    class PalindromeScore
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string strNumber = n.ToString();
            Console.WriteLine(PalindromeScore(strNumber));




        }
        private static bool IsPolidrome(string numberString)
        {
            string first = numberString.Substring(0, numberString.Length / 2);
            char[] numbers = numberString.ToCharArray();
            Array.Reverse(numbers);
            string temp = new string(numbers);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
               

        }
        private static string Reverse(string numberString)
        {
            char[] numbers = numberString.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sb.Append(numbers[i]);
            }
            return sb.ToString();
        }

        private static string Score(string numberString)
        {

            int revnumber = int.Parse(Reverse(numberString));
            int number = int.Parse(numberString);
            numberString = (revnumber + number).ToString();
            return numberString;
        }

        private static string PalindromeScore(string numberString)
        {
            counter++;
            if (isPalindrome(numberString))
            {
                return counter.ToString();
            }
            return pScore(Score(numberString));
        }

       
    }
}
