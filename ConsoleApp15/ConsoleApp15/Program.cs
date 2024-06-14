
namespace ConsoleApp15
{
    public class InvalidExeption : Exception
    {
        public InvalidExeption() : base("Insufficient fuel for the drive")
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> allCars = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();

                string model = commands[0];
                double fuelAmount = double.Parse(commands[1]);
                double fuelConsumption = double.Parse(commands[2]);

                Car car = new Car()
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumption = fuelConsumption,
                    //Distance = 1
                };

                if (!allCars.ContainsKey(model))
                {
                    allCars.Add(model, car);

                }
                else
                {
                    allCars[model] = car;
                }
            }

            while (true)
            {
                string[] drunkDriving = Console.ReadLine().Split();

                if (drunkDriving[0] == "End")
                {
                    break;
                }

                string model = drunkDriving[1];
                double amount = double.Parse(drunkDriving[2]);

                Car c = allCars[model];

                try
                {
                    c.TripleRent(amount);
                }
                catch(InvalidExeption iex)
                {
                    Console.WriteLine(iex.Message);
                }
            }

            foreach(var item in allCars)
            {
                Console.WriteLine($"{item.Key} {item.Value.FuelAmount:F02} {item.Value.Distance}");
            }
        }
    }
}