using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace Reflections
{
    internal class Reflections
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(#|@)(?<wordOne>[a-zA-Z]{3,})\1\1(?<wordTwo>[a-zA-Z]{3,})\1";

            //var regex = new Regex(text);

            MatchCollection matches = Regex.Matches(text, pattern);

            Dictionary<string, string> dict = new Dictionary<string, string>();

            List<string> words = new List<string>();
            List<string> wordsTwo = new List<string>();

            int count = 0;

            foreach(Match match in matches)
            {
                string wordOne = match.Groups["wordOne"].Value;
                string wordTwo = match.Groups["wordTwo"].Value;

                string reverceWordOne = null;

                for(int i = wordOne.Length - 1; i >= 0; i--)
                {
                    reverceWordOne += wordOne[i];
                }

                if(reverceWordOne == wordTwo)
                {
                    //dict.Add(wordOne, wordTwo);
                    //wordsOne.Add(wordOne);
                    //wordsTwo.Add(wordTwo);

                    words.Add($"{wordOne} <=> {wordTwo}");
                }

                count++;
            }

            if(count <= 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{count} word pairs found!");

            }

            if (words.Count <= 0)
            {
                Console.WriteLine($"No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", words));
            }
            /*
            if(dict.Count <= 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                foreach(var kvp in dict)
                {
                    Console.Write($"{kvp.Key} <=> {kvp.Value}, ");
                }
            }
            */
        }
    }
}