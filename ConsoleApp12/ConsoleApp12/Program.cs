namespace ConsoleApp12
{

    public class CustomExeption : Exception
    {
        public CustomExeption(int start, int end) 
            : base($"Your number is not in range ({start} - {end})!")
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> someNums = new List<int>();

            int start = 1;
            int end = 100;


            while (someNums.Count < 10)
            {
                try
                {
                    someNums.Add(ReadNumber(start, end));

                }
                catch(FormatException fex)
                {
                    Console.WriteLine("Invalid number");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            Console.WriteLine(string.Join(", ", someNums));
        }

        static int ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());

            if(n <= start || n >= end)
            {
                throw new CustomExeption(start, end);
            }

            return n;
        }
    }
}