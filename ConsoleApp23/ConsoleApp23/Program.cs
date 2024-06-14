using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, string>> dict = new Dictionary<string, Dictionary<string, string>>();


            for(int i = 0; i < n; i++)
            {
                string[] pieces = Console.ReadLine().Split("|");

                string piece = pieces[0];
                string composer = pieces[1];
                string key = pieces[2];

                dict.Add(piece, new Dictionary<string, string>());
                dict[piece]["key"] = key;
                dict[piece]["composer"] = composer;
            }

            while (true)
            {
                string[] commnads = Console.ReadLine().Split("|");

                if (commnads[0] == "Stop")
                {
                    break;
                }

                if (commnads[0] == "Add")
                {
                    string piece = commnads[1];
                    string composer = commnads[2];
                    string key = commnads[3];

                    if (!dict.ContainsKey(piece))
                    {
                        dict.Add(piece, new Dictionary<string, string>());
                        //dict[piece].Add(composer, key);
                        dict[piece]["key"] = key;
                        dict[piece]["composer"] = composer;


                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (commnads[0] == "Remove")
                {
                    string piece = commnads[1];

                    if (dict.ContainsKey(piece))
                    {
                        dict.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (commnads[0] == "ChangeKey")
                {
                    string piece = commnads[1];
                    string newKey = commnads[2];

                    if (dict.ContainsKey(piece))
                    {
                        /*
                        var val = dict[piece];
                        dict.Remove(piece);
                        dict.Add(newKey, val);
                        */



                        dict[piece]["key"] = newKey;

                        Console.WriteLine($"Change the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

            }
                
            foreach(var kvp in dict.OrderBy((x) => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> Composer: {kvp.Value["composer"]}, Key: {kvp.Value["key"]}");  
            }
        }
    }
}