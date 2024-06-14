using System.Net.Mail;

namespace Line_Numbers
{
    public class LineNumbers
    {
        static void Main(string[] args)
        {
            ProcessLines(
                @"C:\Users\yan\Desktop\Conway-s-Game-of-Life\Line Numbers\Line Numbers\input.txt",
                @"C:\Users\yan\Desktop\Conway-s-Game-of-Life\Line Numbers\Line Numbers\Output.txt");


        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            using (var writer = new StreamWriter(outputFilePath))
            {
                string line = reader.ReadLine();

                int count = 1;

                while (line != null)
                {
                    int lettersCount = 0;
                    int signCount = 0;

                    foreach (var c in line)
                    {
                        if (char.IsLetter(c))
                        {
                            lettersCount++;
                        }
                        else if (!char.IsDigit(c) && c != ' ')
                        {
                            signCount++;
                        }
                    }

                    //Console.WriteLine($"{count}. {line} ({lettersCount}) ({signCount})");
                    writer.WriteLine($"{count}. {line} ({lettersCount}) ({signCount})");
                    count++;

                    line = reader.ReadLine();
                }
            }

        }


}
}