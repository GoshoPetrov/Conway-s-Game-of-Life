namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> allCars = new List<Car>();

            for(int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                string model = command[0];

                Engine engine = new Engine 
                {
                    Speed = int.Parse(command[1]),
                    Power = int.Parse(command[2])
                };

                Cargo cargo = new Cargo 
                {
                    Weight = int.Parse(command[3]),
                    Type = command[4]
                };

                Tire tire1 = new Tire
                {
                    Pressure = double.Parse(command[5]),
                    Age = int.Parse(command[6])
                };

                Tire tire2 = new Tire
                {
                    Pressure = double.Parse(command[7]),
                    Age = int.Parse(command[8])
                };

                Tire tire3 = new Tire
                {
                    Pressure = double.Parse(command[9]),
                    Age = int.Parse(command[10])
                };

                Tire tire4 = new Tire
                {
                    Pressure = double.Parse(command[11]),
                    Age = int.Parse(command[12])
                };

                Car car = new Car(model, engine, cargo, new Tire[] { tire1, tire2, tire3, tire4 });

                allCars.Add(car);
            }

            string commands = Console.ReadLine();

            if (commands == "fragile")
            {
                foreach(var item in allCars)
                {
                    if(item.Cargo.Type == "fragile")
                    {
                        foreach(var tire in item.Tires)
                        {
                            if(tire.Pressure < 1)
                            {
                                Console.WriteLine(item.Model);
                                break;
                            }
                        }
                    }
                }
            }
            else if(commands == "flamable")
            {
                foreach(var item in allCars)
                {
                    if(item.Cargo.Type == "flamable" && item.Engine.Power > 250)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }


        }
    }
}