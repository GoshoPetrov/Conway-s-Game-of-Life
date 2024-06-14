using System.Text;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Car> allCars = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();

                string model = commands[0];
                double fuelAmount = int.Parse(commands[1]);
                double fuelConsumption = double.Parse(commands[2]);

                Car car = new Car()
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuealConsumption = fuelConsumption,
                    Distance = 0
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
                string[] command = Console.ReadLine().Split();
                if (command[0] == "End")
                {
                    break;
                }

                string model = command[1];
                double kms = double.Parse(command[2]);

                Car cars = allCars[model];

                // v1 
                if (cars.CarCanDrive(kms))
                {
                    cars.Drive(kms);
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                // v2
                try
                {
                    cars.Drive2(kms);


                }
                catch (InsufficientFuelException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach(var item in allCars)
            {
                Console.WriteLine($"{item.Key} {item.Value.FuelAmount:F02} {item.Value.Distance}");
            }
        }
    }
}