using System.Diagnostics;

namespace Pokemon_Trainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> allTrainers = new Dictionary<string, Trainer>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Tournament")
                {
                    break;
                }

                string name = command[0];
                int badges = 0;
                string pokemonName = command[1];
                string element = command[2];
                int health = int.Parse(command[3]);

                Pokemon pokemon = new Pokemon
                {
                    Name = pokemonName,
                    Element = element,
                    Helath = health
                };

                if (!allTrainers.ContainsKey(name))
                {
                    Trainer trainer = new Trainer
                    {
                        Name = name,
                        Badges = badges,
                    };

                    trainer.Pokemons.Add(pokemon);

                    allTrainers.Add(name, trainer);
                }
                else
                {
                    allTrainers[name].Pokemons.Add(pokemon);
                }

                

                
            }

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "End")
                {
                    break;
                }

                foreach(var kvp in allTrainers)
                {
                    bool flag = false;

                    foreach(var item in kvp.Value.Pokemons)
                    {
                        if(item.Element == command)
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (flag)
                    {
                        
                        kvp.Value.Badges += 1;
                                              
                    }
                    else
                    {
                        foreach (var Pokemon in kvp.Value.Pokemons)
                        {
                            Pokemon.Helath -= 10;
                            if(Pokemon.Helath <= 0)
                            {
                                kvp.Value.Pokemons.Remove(Pokemon);
                            }
                        }
                    }
                    
                }
            }

            List<Trainer> sorted = allTrainers.Values.ToList();

            //List<Trainer> sorted = new List<Trainer>();
            //foreach (var kvp in allTrainers)
            //{
            //    sorted.Add(kvp.Value);
            //}



            sorted.Sort((a, b) =>
            {
                return b.Badges - a.Badges;              
            });

            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Name} {kvp.Badges} {kvp.Pokemons.Count}");
            }
        }
    }
}