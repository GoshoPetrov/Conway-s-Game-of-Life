using System.Linq.Expressions;

namespace Car_Salesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Car> allCars = new Dictionary<string, Car>();

            Dictionary<string, Engine> allEngines = new Dictionary<string, Engine>();

            for(int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                string model = command[0];
                int power = int.Parse(command[1]);


                int displacement = 0;
                string efficiency = "n/a";

                if(command.Length == 3)
                {
                    if (IsNumber(command[2]))
                    {
                        displacement = int.Parse(command[2]);
                    }
                    else
                    {
                        efficiency = command[2];
                    }
                }

                if(command.Length == 4)
                {
                    displacement = int.Parse(command[2]);
                    efficiency = command[3];
                }

                Engine engine = new Engine
                {
                    Model = model,
                    Power = power,
                    Displacement = displacement,
                    Efficiency = efficiency
                };

                allEngines.Add(model, engine);
            }

            int m = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++)
            {
                string[] command = Console.ReadLine().Split();

                string model = command[0];
                string engineModel = command[1];
                Engine engine = allEngines[engineModel];

                int weight = 0;
                string color = "n/a";

                if (command.Length == 3)
                {
                    if (IsNumber(command[2]))
                    {
                        weight = int.Parse(command[2]);
                    }
                    else
                    {
                        color = command[2];
                    }
                }
                
                if(command.Length == 4)
                {
                    weight = int.Parse(command[2]);
                    color = command[3];
                }

                Car car = new Car()
                {
                    Model = model,
                    Engine = engine,
                    Weight = weight,
                    Color = color
                };

                allCars.Add(model, car);
                //allCars[model].Add(car);
            }

            foreach(var kvp in allCars)
            {
                Console.WriteLine($"{kvp.Key}: ");
                Console.WriteLine($"    {kvp.Value.Engine.Model}: ");
                Console.WriteLine($"        Power: {kvp.Value.Engine.Power}");
                Console.WriteLine($"        Displacement: {kvp.Value.Engine.Displacement}");
                Console.WriteLine($"        Efficiency: {kvp.Value.Engine.Efficiency}");
                Console.WriteLine($"    Weight: {kvp.Value.Weight}");
                Console.WriteLine($"    Color: {kvp.Value.Color}");
            }
        }

        public static bool IsNumber(string v)
        {
            foreach (char item in v)
            {
                if (!char.IsDigit(item))
                    return false;
            }
            return true;
        }
    }
}