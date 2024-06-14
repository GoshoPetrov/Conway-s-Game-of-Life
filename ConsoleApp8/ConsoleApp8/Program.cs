using System.ComponentModel.DataAnnotations;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Class1
            {
                Name = "John",
                Age = 100
            };

            Console.WriteLine($"a = {a}");
        }
    }
}