using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Car
    {
        private string model;
        private double fuel;
        private double fuelConsumption;
        private double distance;

        public string Model { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }
        public double Distance { get; set; }
        public Car(string model, double fuel, double fuelConsumption)
        {
            this.model = model;
            this.fuel = fuel;
            this.fuelConsumption = fuelConsumption;
        }

        public bool CanYouDrive(double amount)
        {
            return this.Fuel >= this.FuelConsumption * amount;
        }

        public void Drive(double amount)
        {
            if (!CanYouDrive(amount))
            {
                return;
            }
            this.Fuel -= this.FuelConsumption * amount;
            this.Distance += amount;
        }


    }
}
