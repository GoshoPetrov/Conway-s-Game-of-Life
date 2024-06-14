using System.Runtime.CompilerServices;

namespace Word_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CalculateWordCount(@"C:\Users\yan\Desktop\Conway-s-Game-of-Life\Word Count\Word Count\Words.txt", @"C:\Users\yan\Desktop\Conway-s-Game-of-Life\Word Count\Word Count\Input.txt", @"C:\Users\yan\Desktop\Conway-s-Game-of-Life\Word Count\Word Count\Output.txt");
        }

        public void CalculateWordCount(string wordsFilePath, string textFilePath, string ouputFilePath)
        {
            using (var writer = new StreamWriter(ouputFilePath))
            using (var reader = new StreamReader(textFilePath))
            {
                Dictionary<string, int> counts = new Dictionary<string, int>();

                string line = reader.ReadLine();

                string[] moreFiles = wordsFilePath.Split();

                string[] moreLines = line.Split();

                while (line != null)
                {
                    foreach(var item in moreLines)
                    {
                        foreach(var word in moreFiles)
                        {
                            if(item == word)
                            {
                                if (!counts.ContainsKey(item))
                                {
                                    counts.Add(item, 1);
                                }
                                else
                                {
                                    counts[item]++;
                                }
                            }
                        }
                    }
                }

                foreach(var kvp in counts)
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}