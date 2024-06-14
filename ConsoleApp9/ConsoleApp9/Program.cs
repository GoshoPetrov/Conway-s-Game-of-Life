namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nameOrDate = Console.ReadLine();

            Dictionary<string, Person> personByNameOrDate = new Dictionary<string, Person>();

            while (true)
            {
                string[] commnad = Console.ReadLine().Split(" - ");
                if (commnad[0] == "End")
                {
                    break;
                }

                if (commnad.Length == 1)
                {
                    string[] parts = commnad[0].Split();
                    string name = $"{parts[0]} {parts[1]}";
                    string date = parts[2];

                    if (personByNameOrDate.ContainsKey(name) && personByNameOrDate.ContainsKey(date))
                    {
                        // replace all instances of b with a wherever we find them
                        var a = personByNameOrDate[name];
                        var b = personByNameOrDate[date];

                        a.Name = name;
                        a.Date = date;

                        a.Parents.AddRange(b.Parents);
                        a.Children.AddRange(b.Children);

                        personByNameOrDate[name] = a;
                        personByNameOrDate[date] = a;

                        foreach (var item in personByNameOrDate)
                        {
                            if (item.Value.Parents.Remove(b))
                                item.Value.Parents.Add(a);
                            if (item.Value.Children.Remove(b))
                                item.Value.Children.Add(a);
                        }
                    } 
                    else if (personByNameOrDate.ContainsKey(name))
                    {
                        personByNameOrDate[name].Date = date;
                        personByNameOrDate[date] = personByNameOrDate[name];

                    }
                    else if (personByNameOrDate.ContainsKey(date))
                    {
                        personByNameOrDate[date].Name = name;
                        personByNameOrDate[name] = personByNameOrDate[date];

                    }
                    else
                    {
                        Person x = new Person()
                        {
                            Name = name,
                            Date = date
                        };

                        personByNameOrDate[name] = x;
                        personByNameOrDate[date] = x;
                    }

                }
                else
                {

                    Person first = null;
                    Person second = null;

                    string firstPersonNameOrDate = commnad[0];
                    string secondPersonNameOrDate = commnad[1];

                    if (personByNameOrDate.ContainsKey(firstPersonNameOrDate))
                    {
                        first = personByNameOrDate[firstPersonNameOrDate];
                    }
                    else
                    {
                        first = new Person()
                        {
                            Name = firstPersonNameOrDate,
                            Date = firstPersonNameOrDate
                        };

                        personByNameOrDate[firstPersonNameOrDate] = first;
                    }


                    if (personByNameOrDate.ContainsKey(secondPersonNameOrDate))
                    {
                        second = personByNameOrDate[secondPersonNameOrDate];
                    }
                    else
                    {
                        second = new Person()
                        {
                            Name = secondPersonNameOrDate,
                            Date = secondPersonNameOrDate
                        };

                        personByNameOrDate[secondPersonNameOrDate] = second;
                    }

                    first.Children.Add(second);
                    second.Parents.Add(firstj);
                }


            }

            var result = personByNameOrDate[nameOrDate];
            Console.WriteLine(result);

            Console.WriteLine("Parents:");
            foreach (var item in result.Parents)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Children:");
            foreach (var item in result.Children)
            {
                Console.WriteLine(item);
            }

        }
    }
}