using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp15.Program;

namespace ConsoleApp15
{
    internal class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumption { get; set; }

        public double Distance { get; set; }


        public void TripleRent(double amount)
        {
            double kms = amount;

            if (!CrashOrNot(kms))
            {
                throw new InvalidExeption();
            }

            this.FuelAmount -= FuelConsumption * amount;
            this.Distance += amount;

            //if (CrashOrNot(kms))
            //{
            //    this.FuelAmount -= FuelConsumption * amount;
            //    this.Distance += amount;
            //}
            //else
            //{
            //    throw new InvalidExeption();
            //}

        }

        public bool CrashOrNot(double amount)
        {
            return this.FuelAmount > amount * this.FuelConsumption;
        }
    }
}
