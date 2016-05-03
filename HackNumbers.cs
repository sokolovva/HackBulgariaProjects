using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackNumbers
{
    class HackNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");

            int dec = int.Parse(Console.ReadLine());
            string bin = Convert.ToString(dec, 2);


            Console.WriteLine(IsHack(bin));
            Console.WriteLine(NextHack(bin));


        }
        private static bool IsPolidrome(string bin)
        {
             string first = bin.Substring(0, bin.Length / 2);
             char[] arr = bin.ToCharArray();
             Array.Reverse(arr);
             string temp = new string(arr);
             string second = temp.Substring(0, temp.Length / 2);
             return first.Equals(second);
        

        }
        private static bool IsAnOdd( string bin)
        {
            int counter = 0;
            bool isOdd = false;
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '1')
                {
                    counter++;
                    if (counter % 2 != 0)
                    {
                        isOdd = true;

                    }
                }

            }
            return isOdd;

        }
        private static bool IsHack(string bin)
        {

            Console.WriteLine(bin);
            Console.WriteLine(IsPolidrome(bin));
            if (IsPolidrome(bin) && IsAnOdd(bin) == true)
            {
                return true;
            
            }
            else
            {
                return false;
              
            }
        }
        
        private static string NextHack(string bin)
        {
            int n = int.Parse(bin);
            n++;
            while (IsHack(bin))
                {
                n++;
                break;
               
            }
            return n.ToString();
        }
  
       
    
    }
}
