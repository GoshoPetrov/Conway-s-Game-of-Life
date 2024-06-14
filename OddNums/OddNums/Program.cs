namespace OddLines
{
    public class OddLines
    {
        static void Main(string[] args)
        {

            string inputFilePath = "C:\\Users\\yan\\Desktop\\Conway-s-Game-of-Life\\OddNums\\OddNums\\Input.txt";
            string outputFilePath = "C:\\Users\\yan\\Desktop\\Conway-s-Game-of-Life\\OddNums\\OddNums\\Output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            using (var writer = new StreamWriter(outputFilePath))
            {
                int counter = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (counter % 2 == 1)
                    {
                        writer.WriteLine(line);
                    }

                    counter++;
                    line = reader.ReadLine();
                }

            }
        }

    }
}