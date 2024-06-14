namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("C:\\Users\\yan\\Desktop\\Conway-s-Game-of-Life\\ConsoleApp13\\ConsoleApp13\\Data.txt");

            Dictionary<string, List<Student>> allStudents = new Dictionary<string, double[]>();


            foreach (var item in input)
            {
                try
                {
                    Student student = new Student(item);
                    if (!allStudents.ContainsKey(student.Name))
                    {
                        allStudents.Add(student.Name, new List<Student>());
                    }

                    allStudents[student.Name].Add(student);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                
                
            }

        }
    }
}