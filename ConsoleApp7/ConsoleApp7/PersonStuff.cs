using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class PersonStuff
    {
        public string Name { get; set; }

        public Company Company { get; set; }

        public List<Pokemon> Pokemon { get; set; } = new List<Pokemon>();

        public List<Parents> Parents { get; set; } = new List<Parents>();

        public List<Children> Children { get; set; } = new List<Children>();

        public Car Car { get; set; }


    }
}
