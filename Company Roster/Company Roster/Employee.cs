﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Company_Roster
{
    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee(string name, double salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.age = -1;
            this.email = "n/a";
        }

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public string Email { 
            get { return this.email; } 
            set { this.email = value; } 
        }
        public int Age { 
            get { return this.age; } 
            set { this.age = value; } 
        }

        public string Print()
        {
            return $"{this.name} {this.salary:F02} {this.email} {this.age}";
        }
    }
}
