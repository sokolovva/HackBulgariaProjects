using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsonantsInAString
{
    class ConsonantsInAString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string ");
            string strUpperCase = Console.ReadLine();
            string str = strUpperCase.ToLower();
            string[] strArr = str.Split(new[] { ' ', ',', '.', '!', '?' });
            char[] charArray = string.Join(string.Empty, strArr).ToCharArray();

            int counter = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] != 'a' && charArray[i] != 'e' && charArray[i] != 'i' && charArray[i] != 'o'
                    && charArray[i] != 'u' && charArray[i] != 'y')
                {
                    counter++;
                  
                }
              

            }
            Console.WriteLine(counter);
        }
    }
}
