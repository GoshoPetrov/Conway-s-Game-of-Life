namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(", ");

            Article article = new Article
            {
                Title = command[0],
                Content = command[1],
                Author = command[2]
            };

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i< n; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");

                if (commands[0] == "Edit")
                {
                    article.Edit(commands[1]);
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    article.ChnageAuthor(commands[1]);
                }
                else if (commands[0] == "Rename")
                {
                    article.Rename(commands[1]);
                }
            }

            article.Print();
        }
    }
}