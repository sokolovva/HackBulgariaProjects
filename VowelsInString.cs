using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsInString
{
    class VowelsInString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string ");
            string strUpperCase = Console.ReadLine();
            string str=   strUpperCase.ToLower();
            char[] strArray = str.ToCharArray();
            int counter = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i]=='a' || strArray[i] =='e' || strArray[i] == 'i' || strArray[i] == 'o'
                    || strArray[i] == 'u' || strArray[i] == 'y' )
                {
                    counter++;
                   
                }
                
            }
            Console.WriteLine(counter);



        }
    }
}
