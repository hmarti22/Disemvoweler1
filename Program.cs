using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)          
        {
            string input = ("I'm a code ninja, baby. I make the functions and i make the calls!");
            Disemvowel(input);
            Console.ReadKey();
        }
        static void Disemvowel(string input)
        {
            string disemvowel = input.ToString();
          string vowel = "";
          string consonant = "";
          
        for (int i = 0; i < disemvowel.Length -1; i++)
			{
			 char letter = disemvowel[i];
            if ( letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                vowel = vowel + input[i];
            }
            else if (letter == ' '||letter == ' '||letter == ' '||letter == ' '||letter == ' ')
            {
                vowel = vowel;
            }
            else
            {
                consonant = consonant + input [i];
            }

		}
            Console.WriteLine(vowel);
            Console.WriteLine(consonant);
            Console.WriteLine(input);
        }
    }
}
