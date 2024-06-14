using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> aaa = new List<int>(new int[] { 1, 2, 3, 4, 5 });
            //aaa.Reverse();

            //aaa.Sort((a, b) =>
            //{
            //    if (a == 3) return -1;
            //    if (b == 3) return 1;

            //    return a - b;
            //});

            //foreach (var item in aaa)
            //{
            //    Console.WriteLine(item);
            //}

            //return;




            int n = int.Parse(Console.ReadLine());

            List<Class1> list = new List<Class1>();
            //List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();

                string name = data[0];
                int age = int.Parse(data[1]);

                Class1 c = new Class1();
                c.Name = name;
                c.Age = age;

                list.Add(c);
                //list.Add(name);

            }

            list.Sort((Class1 a, Class1 b) =>
            {
                int x = string.Compare(a.Name, b.Name);
                if (x == 0)
                {
                    if (a.Age > b.Age) return 1;
                    if (a.Age < b.Age) return -1;
                    return 0;
                }
                return x;
            });

            foreach(Class1 j in list)
            {
                Console.WriteLine($"{j.PersonData()}");
            }
        }
    }
}