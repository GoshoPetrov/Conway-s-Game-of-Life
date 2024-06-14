namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> dict = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string model = command[0];
                double fuel = double.Parse(command[1]);
                double fuelConsumption = double.Parse(command[2]);

                Car c = new Car(model, fuel, fuelConsumption);

                dict.Add(model, c);
            }


            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "End")
                {
                    break;
                }

                string model = command[1];
                double amount = double.Parse(command[2]);

                Car c = dict[model];
                if (c.CanYouDrive(amount))
                {
                    c.Drive(amount);
                }
                else
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
            }

            foreach (var kvp in carByModel)
            {
                Console.WriteLine($"{kvp.Value.Model} {kvp.Value.Fuel:F02} {kvp.Value.Distance}");
            }
        }
    }
}