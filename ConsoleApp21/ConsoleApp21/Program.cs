using System.Runtime.Serialization.Json;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");

            var sb = new StringBuilder(Console.ReadLine());

            foreach(var ban in bannedWords)
            {
                if (sb.ToString().Contains(ban))
                {
                    sb = sb.Replace(ban, new string('*', ban.Count()));
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}