using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace CharHistogram
{
    class CharHistogram
    {
        static void Main(string[] args)
        {
           
            Console.Write("Please, enter a string: ");
           
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }

            foreach(KeyValuePair<char,int> character in characterCount)
            {
                
                Console.WriteLine("Key = {0}, Value = {1}", character.Key, character.Value);
            }

        }
    }
}
