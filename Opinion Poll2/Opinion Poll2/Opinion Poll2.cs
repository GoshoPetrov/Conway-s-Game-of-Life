namespace Opinion_Poll2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Person person = new Person();

            List<string> p = new List<string>();

            string result;

            for(int i = 0; i < n; i++)
            {
                string[] people = Console.ReadLine().Split();

                string name = people[0];
                int age = int.Parse(people[1]);

                result = person.PeopleOlder(name, age);

                if (age > 30)
                {
                    p.Add(result);
                }

               
            }

            p.Sort();

            foreach(string g in p)
            {
                Console.WriteLine(g);
            }
        }
    }
}