namespace Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            
            try
            {
                if (n < 0.0)
                {
                    throw new Exception("Invalid number.");
                }

                double result = Math.Sqrt(n);
                Console.WriteLine(result);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }


        }

    }
}