namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, PersonStuff> allPeople = new Dictionary<string, PersonStuff>();

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

                string whatIsIt = command[1];

                if (command[1] == "company")
                {
                    company = new Company
                    {
                        CompanyName = command[2],
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
                    PersonStuff person = new PersonStuff()
                    {
                        Name = names,
                        Car = car,
                        Company = company
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
                    PersonStuff person = allPeople[names];

                    if(company != null)
                    {
                        person.Company = company;
                    }
                    
                    if(car != null)
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

            PersonStuff result = allPeople[name];

            Console.WriteLine(name);

            Console.WriteLine($"Company:");
            if(result.Company != null)
            {
                Console.WriteLine($"{result.Company.CompanyName} {result.Company.Department} {result.Company.Salary:F02}");
            }
            Console.WriteLine("Car:");
            if (result.Car != null)
            {
                Console.WriteLine($"{result.Car.Model} {result.Car.Speed}");
            }
            Console.WriteLine("Pokemon:");
            if(result.Pokemon != null)
            {
                foreach(var item in result.Pokemon)
                {
                    Console.WriteLine($"{item.PokemonName} {item.Type}");
                }
            }
            Console.WriteLine("Parents:");
            if (result.Parents != null)
            {
                foreach (var item in result.Parents)
                {
                    Console.WriteLine($"{item.ParentName} {item.Birthday}");
                }
            }
            Console.WriteLine("Children:");
            if (result.Children != null)
            {
                foreach (var item in result.Children)
                {
                    Console.WriteLine($"{item.ChildName} {item.Birthday}");
                }
            }
            
        }
    }
}