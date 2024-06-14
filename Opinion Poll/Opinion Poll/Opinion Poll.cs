using System.Collections.Immutable;

namespace Opinion_Poll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Person> f = new List<Person>();

            for(int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();

                Person person = new Person();

                person.Name = data[0];
                person.Age = int.Parse(data[1]);

                if (person.Age > 30)
                {
                    f.Add(person);
                }         

            }

            
            f.Sort((a, b) => string.Compare(a.Name, b.Name));
            foreach (var x in f)
            {
                Console.WriteLine(x.PersonData());
            }
            
        }
    }
}