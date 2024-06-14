using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age { get; internal set; }


        public string PersonData()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
