namespace Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Phrases = new string[] { "Excellent product", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can'tlive without this product." };
            string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int Phrases2 = random.Next(Phrases.Length);
                int Events2 = random.Next(Events.Length);
                int Authors2 = random.Next(Authors.Length);
                int cities2 = random.Next(Cities.Length);

                Console.WriteLine($"{Phrases[Phrases2]} {Events[Events2]} {Authors[Authors2]} {Cities[cities2]}");
            }
        }
    }
}