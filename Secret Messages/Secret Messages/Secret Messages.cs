namespace Secret_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string[] commnads = Console.ReadLine().Split("<->");
                if (commnads[0] == "Read")
                {
                    break;
                }

                if (commnads[0] == "Space")
                {
                    int index = int.Parse(commnads[1]);

                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (commnads[0] == "Backward")
                {
                    string substring = commnads[1];
                    if (message.Contains(substring))
                    {
                        message = message.Remove(message.IndexOf(substring), substring.Length);
                        string reversed = "";

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reversed += substring[i];
                        }

                        message += reversed;

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commnads[0] == "ReplaceAll")
                {
                    string substring = commnads[1];
                    string replacement = commnads[2];

                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }

            }

            Console.WriteLine($"You have a secret text message: {message}");
        }
    }
}