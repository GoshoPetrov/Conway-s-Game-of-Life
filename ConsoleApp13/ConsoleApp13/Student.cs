using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{

    public class StudentExeption : Exception
    {
        public StudentExeption() : base("Invalid student")
        {

        }
    }
    internal class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; } = new List<double>();

        public Student(string item)
        {
            string[] person = item.Split();
            this.Name = person[0];

            try
            {
                for (int i = 1; i < person.Length; i++)
                {
                    this.Grades.Add(double.Parse(person[i]));
                }
            }
            catch (Exception ex)
            {
                throw new StudentExeption();
            }
        }
    }
}
