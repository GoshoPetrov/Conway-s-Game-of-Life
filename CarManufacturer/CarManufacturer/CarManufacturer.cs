using System.Reflection;

namespace CarManufacturer
{
    internal class CarManufacturer
    {
        static void Main(string[] args)
        {

            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());

            //Car firstCar = new Car();

            //Car secondCar = new Car(make, model, year);

            //Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption );


            //var tires = new Tire[4]
            //{
            //    new Tire(1, 2.5),
            //    new Tire(1, 2.1),
            //    new Tire(2, 0.5),
            //    new Tire(2, 2.3),

            //};

            //var engine = new Engine(560, 6300);

            //var car = new Car("Lamborgini", "Urus", 2010, 250, 9, engine, tires);

            List<Tire[]> ts = new List<Tire[]>();
            string command = Console.ReadLine();
            while (command != "No more tires")
            {
                string[] parts = command.Split();

                Tire tire1 = new Tire(int.Parse(parts[0]), double.Parse(parts[1]));
                Tire tire2 = new Tire(int.Parse(parts[2]), double.Parse(parts[3]));
                Tire tire3 = new Tire(int.Parse(parts[4]), double.Parse(parts[5]));
                Tire tire4 = new Tire(int.Parse(parts[6]), double.Parse(parts[7]));

                Tire[] tires = new Tire[] { tire1, tire2, tire3, tire4 };
                ts.Add(tires);
                command = Console.ReadLine();
            }

            List<Engine> es = new List<Engine>();
            command = Console.ReadLine();
            while (command != "Engines done")
            {
                string[] parts = command.Split();
                Engine e = new Engine(int.Parse(parts[0]), double.Parse(parts[1]));
                es.Add(e);
                command = Console.ReadLine();
            }

            List<Car> cs = new List<Car>();
            command = Console.ReadLine();
            while(command != "Show special")
            {
                string[] parts = command.Split();

                int engineIndex = int.Parse(parts[5]);
                int tireIndex = int.Parse(parts[6]);

                Tire[] carTires = ts[tireIndex];
                
                Car c = new Car(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), double.Parse(parts[4]), es[engineIndex], carTires);
                cs.Add(c);

                command = Console.ReadLine();

            }

            foreach (var item in cs)
            {
                double tirePressure = 0;
                foreach (var tireItem in item.Tire)
                {
                    tirePressure += tireItem.Pressure;
                }

                if (item.Year >= 2017 
                    && item.Engine.HorsePower > 330 
                    && tirePressure > 9 && tirePressure < 10)
                {
                    item.Drive(20.0 / 100.0);

                    Console.WriteLine($"Make: {item.Make}");
                    Console.WriteLine($"Model: {item.Model}");
                    Console.WriteLine($"Year: {item.Year}");
                    Console.WriteLine($"HorsePower: {item.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {item.FuelQuantity}");
                }
            }


        }
    }
}