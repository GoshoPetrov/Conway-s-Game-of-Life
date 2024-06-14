namespace Company_Roster2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> e = new List<Employee>();

            var dict = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
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
                    

                    if (IsNum(command[4]))
                    {
                        email = command[4];
                    }
                    else
                    {
                        age = int.Parse(command[4]);
                    }
                }

                if(command.Length == 6)
                {
                    email = command[4];
                    age = int.Parse(command[5]);
                }

                Employee emplyees = new Employee(name, salary, position, department);

                emplyees.Email = email;
                emplyees.Age = age;

                e.Add(emplyees);

                if (!dict.ContainsKey(emplyees.Department))
                {
                    dict.Add(emplyees.Department, new List<double>());
                }

                dict[emplyees.Department].Add(salary);              
            }

            string bestDepartment = null;
            double bestAvgSalary = 0;

            foreach(var kvp in dict)
            {
                if(bestAvgSalary < kvp.Value.Sum() / kvp.Value.Count())
                {
                    bestAvgSalary = kvp.Value.Sum() / kvp.Value.Count();
                    bestDepartment = kvp.Key;
                }
            }

            List<Employee> f = new List<Employee>();

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            foreach(var item in e)
            {
                if(item.Department == bestDepartment)
                {
                    f.Add(item);
                }
            }

            f.Sort((a, b) =>
            {
                if (a.Salary > b.Salary) return -1;
                if (a.Salary < b.Salary) return 1;
                return 0;
            });

            foreach (var item in f)
            {
                Console.WriteLine(item.Write());
            }
        }

        static bool IsNum(string command)
        {
            foreach(char item in command)
            {
                if (!char.IsDigit(item))
                {
                    return true;
                }
            }

            return false;
        }

    }
}