using System;

namespace Family_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOrDate = Console.ReadLine();

            Dictionary<string, Person> persons = new Dictionary<string, Person>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End") break;

                string[] connection = line.Split(" - ");
                if (connection.Length > 1)
                {


                    Person p1 = null;
                    if (persons.ContainsKey(connection[0]))
                    {
                        p1 = persons[connection[0]];
                    }
                    else
                    {
                        p1 = new Person()
                        {
                            Name = connection[0],
                            BirthDate = connection[0]
                        };
                        persons[connection[0]] = p1;
                    }

                    Person p2 = null;
                    if (persons.ContainsKey(connection[1]))
                    {
                        p2 = persons[connection[1]];
                    }
                    else
                    {
                        p2 = new Person()
                        {
                            Name = connection[1],
                            BirthDate = connection[1]
                        };
                        persons[connection[1]] = p2;
                    }

                    p1.Children.Add(p2);
                    p2.Parents.Add(p1);

                }
                else
                {
                    string[] parts = line.Split();

                    string name = $"{parts[0]} {parts[1]}";
                    string date = parts[2];

                    if (persons.ContainsKey(name))
                    {
                        persons[name].BirthDate = date;
                    }
                    else if (persons.ContainsKey(date))
                    {
                        persons[date].Name = name;
                    }
                    else
                    {
                        Person p = new Person()
                        {
                            Name = name,
                            BirthDate = date
                        };

                        persons[name] = p;
                        persons[date] = p;
                    }
                }
            }

            Person result = persons[nameOrDate];

            Console.WriteLine(result.Name);
            Console.WriteLine("Parents:");
            foreach (var item in result.Parents)
            {
                Console.WriteLine($"{item.Name} {item.BirthDate}");
            }
            Console.WriteLine("Children:");
            foreach (var item in result.Children)
            {
                Console.WriteLine($"{item.Name} {item.BirthDate}");
            }
        }
    }
}