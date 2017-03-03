using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioClass2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a string to count the characters.");
            //string myString = Console.ReadLine();

            string myString = System.IO.File.ReadAllText(@"C:\Users\Tammy\lc101\csharp-exercises\StudioClass2\text.txt");

            Dictionary<char, int> letters = new Dictionary<char, int>();
            
            foreach (char c in myString)
            {
                if (Char.IsLetter(c))
                {
                    if (letters.ContainsKey(c))
                    {
                        letters[c] += 1;
                    }
                    else
                    {
                        letters.Add(c, 1);
                    }
                }
            }

            foreach (KeyValuePair<char,int> letter in letters)
            {
                Console.WriteLine(letter.Key + ": " + letter.Value);

            }

            Console.ReadLine();
        }
    }
}
