

using System.Text.RegularExpressions;
using System.Xml;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            string pattern = @"(#|[|])(?<name>[a-z A-Z]+)\1(?<date>\d\d\/\d\d\/\d\d)\1(?<calories>\d+)\1";
            var regex = new Regex(pattern);

            MatchCollection foodStuff = regex.Matches(text);

            List<Dictionary<string, object>> diff = new List<Dictionary<string, object>>();
            int sum = 0;

            foreach (Match food in foodStuff)
            {
                string name = food.Groups["name"].Value;

                string date = food.Groups["date"].Value;

                string str = food.Groups["calories"].Value;
                if (str.Length > 5)
                {
                    continue;
                }

                int cals = int.Parse(str);

                sum += cals;


                var dict = new Dictionary<string, object>();
                dict.Add("name", name);
                dict.Add("date", date);
                dict.Add("cals", cals);

                diff.Add(dict); 
            }

            int days = (int)Math.Floor(sum / 2000.0);

            Console.WriteLine($"You have food to last you for: {days} days!");


            foreach(var item in diff)
            {
                Console.WriteLine($"Item: {item["name"]}, Best before: {item["date"]}, Nutrition: {item["cals"]}");
            }

        }
    }
}