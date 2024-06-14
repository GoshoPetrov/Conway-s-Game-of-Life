using System.Reflection.Metadata;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\");

            string[] extention = path[path.Length - 1].Split(".");

            string first = null;

            string second = null;

            if(extention.Length == 1)
            {
                first = extention[0];
            }
            else
            {
                first = extention[0];
                second = extention[1];
            }

            Console.WriteLine($"File name: {first}");
            Console.WriteLine($"File extention: {second}");
        }
    }
}