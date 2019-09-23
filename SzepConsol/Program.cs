using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzepConsol
{
    public class Program
    {

        private static string originalSong = "Szép az ici-pici noi cipo,\n noi cipo,\n noi cipo.\n Benne takarosan lépked a nö,\n lépked a nö,\n a nööö.";

        private static char[] realVowels = { 'a', 'á', 'e', 'é', 'o', 'ò', 'i', 'ì', 'u', 'ú', 'ö', };

        static void Main(string[] args)
        {

            Console.WriteLine("Hi! This is just a silly song \n\n {0}", originalSong);

            Console.WriteLine("Now enter a vowel \n");

            while(true)
            {                
                char inputVowel = Console.ReadKey().KeyChar;

                if (realVowels.Contains(inputVowel))
                {
                    string newSong = ChangeSong(inputVowel, originalSong);
                    Console.WriteLine("\nAnd this is an even sillier song:\n\n {0}", newSong);
                    break;
                }

                Console.WriteLine("\nThis is not a valid vowel. Try again.\n");
            } 

        }


        public static string ChangeSong(char inputVowel, string song)
        {
          
            StringBuilder sb = new StringBuilder(song);
       
            foreach (char item in song)
            {
                if (realVowels.Contains(item))
                {
                    sb.Replace(item, inputVowel).ToString();
                }
            }

            string newSong = sb.ToString();
            return newSong;
        }

    }
}
