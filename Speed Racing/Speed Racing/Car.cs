using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Racing
{
    public class Car
    {
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }
        public double Distance { get; set; }

        public Car(string model, double fuel, double fuelConsumption)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
            this.Distance = 0;
        }

        public bool CanDrive(double amount)
        {
            return this.Fuel >= this.FuelConsumption * amount;
        }

        public void Drive(double amount)
        {
            if (!CanDrive(amount)) return;
            this.Fuel -= this.FuelConsumption * amount;
            this.Distance += amount;
        }

        public bool Drive2(double amount)
        {
            if (this.Fuel >= this.FuelConsumption * amount)
            {
                return false;
            }
            this.Fuel -= this.FuelConsumption * amount;
            this.Distance += amount;

            return true;
        }
    }
}
