namespace Enter_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = new List<int>();

            while (nums.Count() < 10)
            {

                try
                {
                    int n = ReadNumber(1, 100);
                    nums.Add(n);

                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            Console.WriteLine(string.Join(", ", nums));
        }

        static int ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());

            if(n <= start || n >= end)
            {
                throw new Exception($"Your number is not in range {start} - {end}!");
            }

            return n;
        }
    }
}