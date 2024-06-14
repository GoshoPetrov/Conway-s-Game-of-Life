namespace Civilization_VI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<int>>();

            while (true)
            {
                string[] commands = Console.ReadLine().Split("---");
                if (commands[0] == "Build")
                {
                    break;
                }

                string name = commands[0];
                int facilities = int.Parse(commands[1]);
                int score = int.Parse(commands[2]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<int>());

                    dict[name].Add(facilities);
                    dict[name].Add(score);
                }
                else
                {
                    dict[name][0] += facilities;
                    dict[name][1] += score;
                }

            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split(">>");

                if (commands[0] == "End")
                {
                    break;
                }

                if (commands[0] == "Sabotage")
                {
                    string city = commands[1];
                    int facilities = int.Parse(commands[2]);
                    int score = int.Parse(commands[3]);

                    if (dict[city][0] >= facilities && dict[city][1] >= score)
                    {
                        Console.WriteLine($"Campus in {city} is sabotaged! You now have {facilities} less functioning facilities and decreased with {score} science score.");


                        if (dict[city][0] - facilities > 0 && dict[city][1] - score > 0)
                        {
                            dict[city][0] -= facilities;
                            dict[city][1] -= score;
                        }
                        else
                        {
                            dict.Remove(city);
                            Console.WriteLine($"The campus in {city} has been destroyed!");
                        }
                    }
           
                    
                }
                else if (commands[0] == "Boost")
                {
                    string city = commands[1];
                    int score = int.Parse(commands[2]);

                    if(score < 0)
                    {
                        Console.WriteLine("Score cannot be boosted with a negative amount!");
                    }
                    else
                    {
                        dict[city][1] += score;

                        Console.WriteLine($"{score} science boost added to the Campus in {city}. The Campus now has total science score: {dict[city][1]}.");
                    }
                }
            }

            if(dict.Count <= 0)
            {
                Console.WriteLine($"Pity! All Campuses have been sabotaged and destroyed!");
            }
            else
            {
                Console.WriteLine($"You have {dict.Count} Campuses discovering science:");
                foreach (var kvp in dict.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{kvp.Key} -> Facilities: {kvp.Value[0]}, Science score: {kvp.Value[1]}");
                }
            }

        }
    }
}