namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Engine> allEngines = new Dictionary<string, Engine>();

            Dictionary<string, Car> allCars = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] engineCommands = Console.ReadLine().Split();

                string model = engineCommands[0];
                int power = int.Parse(engineCommands[1]);

                int displacement = 0;
                string efficiency = "n/a";

                if(engineCommands.Length == 3)
                {
                    if (IsNum(engineCommands[2]))
                    {
                        displacement = int.Parse(engineCommands[2]);
                    }
                    else
                    {
                        efficiency = engineCommands[2];
                    }
                }
                else if(engineCommands.Length == 4)
                {
                    displacement = int.Parse(engineCommands[2]);
                    efficiency = engineCommands[3];
                }

                Engine engine = new Engine
                {
                    Model = model,
                    Power = power,
                    Displacement = displacement,
                    Efficiency = efficiency
                };

                if (allEngines.ContainsKey(model))
                {
                    allEngines.Add(model, engine);
                }
                else
                {
                    allEngines[model] = engine;
                }
            }

            int m = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++)
            {
                string[] commnads = Console.ReadLine().Split();

                string model = commnads[0];

                string engineModel = commnads[1];

                Engine engine = allEngines[engineModel];
                
                int weight = 0;
                string color = "n/a";

                if (commnads.Length == 3)
                {
                    //if (IsNum(commnads[2]))
                    try
                    {
                        weight = int.Parse(commnads[2]);
                    }
                    catch
                    {
                        color = commnads[2];
                    }
                }
                else if (commnads.Length == 4)
                {
                    weight = int.Parse(commnads[2]);
                    color = commnads[3];
                }

                Car car = new Car
                {
                    Model = model,
                    Engine = engine,
                    Wight = weight,
                    Color = color
                };

                if (allCars.ContainsKey(model))
                {
                    allCars.Add(model, car);
                }
                else
                {
                    allCars[model] = car;
                }
            }

            foreach (var kvp in allCars)
            {
                Console.WriteLine($"{kvp.Key}: ");
                Console.WriteLine($"    {kvp.Value.Engine.Model}: ");
                Console.WriteLine($"        Power: {kvp.Value.Engine.Power}");
                Console.WriteLine($"        Displacement: {kvp.Value.Engine.Displacement}");
                Console.WriteLine($"        Efficiency: {kvp.Value.Engine.Efficiency}");
                Console.WriteLine($"    Weight: {kvp.Value.Wight}");
                Console.WriteLine($"    Color: {kvp.Value.Color}");
            }
        }

        static bool IsNum(string items)
        {
            foreach (char item in items)
            {
                if (!char.IsDigit(item))
                {
                    return false;

                }
            }
            return true;
        }
    }
}