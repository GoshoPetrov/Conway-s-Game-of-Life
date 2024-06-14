namespace Sum_of_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            string[] elements = Console.ReadLine().Split();

            foreach(var item in elements)
            {
                try
                {
                    int n = int.Parse(item);
                    sum += n;
                }
                catch(FormatException fex)
                {
                    Console.WriteLine($"The element '{item}' is in wrong format!");
                }
                catch(OverflowException oex)
                {
                    Console.WriteLine($"The element '{item}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{item}' processed - current sum: {sum}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}