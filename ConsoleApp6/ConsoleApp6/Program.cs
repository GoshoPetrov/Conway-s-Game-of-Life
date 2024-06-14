namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> allPeople = new Dictionary<string, Person>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "End")
                {
                    break;
                }

                string names = command[0];

                Company company = null;
                Pokemon pokemon = null;
                Parents parents = null;
                Children children = null;
                Car car = null;

                if (command[1] == "company")
                {
                    company = new Company
                    {
                        Name = command[2],
                        Department = command[3],
                        Salary = double.Parse(command[4])
                    };
                }
                else if (command[1] == "pokemon")
                {
                    pokemon = new Pokemon
                    {
                        PokemonName = command[2],
                        Type = command[3]
                    };
                }
                else if (command[1] == "parents")
                {
                    parents = new Parents
                    {
                        ParentName = command[2],
                        Birthday = command[3]
                    };
                }
                else if (command[1] == "children")
                {
                    children = new Children
                    {
                        ChildName = command[2],
                        Birthday = command[3]
                    };
                }
                else if (command[1] == "car")
                {
                    car = new Car
                    {
                        Model = command[2],
                        Speed = int.Parse(command[3])
                    };
                }


                if (!allPeople.ContainsKey(names))
                {
                    Person person = new Person
                    {
                        Name = names,
                        Company = company,
                        Car = car
                    };

                    if (pokemon != null)
                    {
                        person.Pokemon.Add(pokemon);
                    }
                    if (parents != null)
                    {
                        person.Parents.Add(parents);
                    }
                    if (children != null)
                    {
                        person.Children.Add(children);
                    }

                    allPeople.Add(names, person);
                }
                else
                {
                    Person person = allPeople[names];

                    if (company != null)
                    {
                        person.Company = company;
                    }
                    if (car != null)
                    {
                        person.Car = car;
                    }

                    if (pokemon != null)
                    {
                        person.Pokemon.Add(pokemon);
                    }
                    if (parents != null)
                    {
                        person.Parents.Add(parents);
                    }
                    if (children != null)
                    {
                        person.Children.Add(children);
                    }
                }
            }

            string name = Console.ReadLine();

            Person result = allPeople[name];

            Console.WriteLine(result.Name);
            Console.WriteLine($"Company:");
            if (result.Company != null)
            {
                Console.WriteLine($"{result.Company.Name} {result.Company.Department} {result.Company.Salary:F02}");
            }
            Console.WriteLine($"Car:");
            if (result.Car != null)
            {
                Console.WriteLine($"{result.Car.Model} {result.Car.Speed}");
            }
            Console.WriteLine($"Pokemon:");
            foreach (var item in result.Pokemon)
            {
                Console.WriteLine($"{item.PokemonName} {item.Type}");
            }
            Console.WriteLine($"Parents:");
            foreach (var item in result.Parents)
            {
                Console.WriteLine($"{item.ParentName} {item.Birthday}");
            }
            Console.WriteLine($"Children:");
            foreach (var item in result.Children)
            {
                Console.WriteLine($"{item.ChildName} {item.Birthday}");
            }

        }
        
    }
}