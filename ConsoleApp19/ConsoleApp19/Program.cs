using System.Text;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(", ").ToList();

            var filtered = words.Where((x) => IsValid(x));

            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
        }

        static bool IsValid(string s)
        {
            if (s.Length < 3 || s.Length > 16)
            {
                return false;
            }

            foreach (var item in s)
            {
                if (char.IsLetter(item) || char.IsDigit(item) || item == '-' || item == '_')
                {

                }
                else
                {
                    return false;
                }
            }

            return true;
        }

    }
}