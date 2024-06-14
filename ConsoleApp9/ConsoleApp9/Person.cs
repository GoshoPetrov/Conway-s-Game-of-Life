using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Person
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public List<Person> Children { get; private set; } = new List<Person>();
        public List<Person> Parents { get; private set; } = new List<Person>();

        public override string ToString()
        {
            return $"{this.Name} {this.Date}";
        }
    }
}
