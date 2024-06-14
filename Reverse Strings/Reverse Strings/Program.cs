namespace Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string commnad = Console.ReadLine();

                string reverceWord = null;

                if(commnad == "end")
                {
                    break;
                }

                for(int i = 0; i < commnad.Length; i++)
                {
                    reverceWord += commnad[commnad.Length - 1 - i];
                }

                Console.WriteLine($"{commnad}={reverceWord}");
            }
        }
    }
}