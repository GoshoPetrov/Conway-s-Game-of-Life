using System.Net.Http.Headers;

namespace Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employes = new List<Employee>();
            Dictionary<string, List<double>> byDepartment = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                string name = command[0];
                double salary = double.Parse(command[1]);
                string position = command[2];
                string department = command[3];

                string email = "n/a";
                int age = -1;

                if (command.Length == 5)
                {
                    if (IsNumber(command[4]))
                    {
                        age = int.Parse(command[4]);
                    }
                    else
                    {
                        email = command[4];
                    }

                }

                if (command.Length == 6)
                {
                    email = command[4];
                    age = int.Parse(command[5]);
                }

                Employee e = new Employee(name, salary, position, department);
                e.Email = email;
                e.Age = age;

                employes.Add(e);

                if (!byDepartment.ContainsKey(department))
                {
                    byDepartment.Add(department, new List<double>());
                }

                byDepartment[department].Add(salary);
            }

            string bestDepartment = null;
            double bestAvgSalary = 0;

            foreach (var kvp in byDepartment)
            {
                double avg = kvp.Value.Sum() / kvp.Value.Count;

                if (avg > bestAvgSalary)
                {
                    bestAvgSalary = avg;
                    bestDepartment = kvp.Key;
                }
            }

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            List<Employee> dl = new List<Employee>();
            foreach (var item in employes)
            {
                if (item.Department == bestDepartment)
                {
                    dl.Add(item);
                }
            }

            //List<Employee> dl2 = employes
            //    .Where((x) => x.Department == bestDepartment)
            //    .ToList();

            dl.Sort((a, b) =>
            {
                if (a.Salary > b.Salary) return -1;
                if (a.Salary < b.Salary) return 1;
                return 0;
            });

            foreach (var item in dl)
            {
                Console.WriteLine(item.Print());
            }



        }

        public static bool IsNumber(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}