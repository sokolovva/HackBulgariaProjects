using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SumAllNumbers
{
    class SumAllNumbers
    {
        static void Main(string[] args)
        {


            Regex regex = new Regex(@"\d+");
            string input = Console.ReadLine();
            Match match = regex.Match(input);
            int sum = 0;
            while(match.Success)
            {
                sum = sum + int.Parse(match.Value);
                match = match.NextMatch();
            }
            Console.WriteLine(sum);


        }
    }
}
