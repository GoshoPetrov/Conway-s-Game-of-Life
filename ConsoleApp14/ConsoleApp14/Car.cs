using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{

    public class InsufficientFuelException : Exception
    {
        public InsufficientFuelException()
            : base("Insufficient fuel for the drive")
        {

        }
    }

    internal class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuealConsumption { get; set; }

        public double Distance { get; set; }

        public int DrivedDistance { get; set; }


        public double Drive(double kms)
        {
            double amount = kms;

            if (CarCanDrive(amount))
            {
                this.FuelAmount -= kms * this.FuealConsumption;
                this.Distance += kms;
            }

            return this.FuelAmount;
        }
        public void Drive2(double kms)
        {
            if (kms * this.FuealConsumption > FuelAmount)
            {
                throw new InsufficientFuelException();
            }
                
            this.FuelAmount -= kms * this.FuealConsumption;
            this.Distance += kms;

        }

        public bool CarCanDrive(double kms)
        {
            if(kms * this.FuealConsumption > FuelAmount)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
