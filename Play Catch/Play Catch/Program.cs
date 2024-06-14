using System;
using System.Reflection;

namespace Play_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = 0;

            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                try
                {
                    if (commands[0] == "Replace")
                    {
                        int index = int.Parse(commands[1]);
                        int element = int.Parse(commands[2]);

                        nums[index] = element;
                    }
                    else if (commands[0] == "Print")
                    {
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);

                        int x = nums[startIndex];
                        x = nums[endIndex];

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            if(i == endIndex)
                            {
                                Console.Write($"{nums[i]}");
                            }
                            else
                            {
                                Console.Write($"{nums[i]}, ");
                            }
                            
                        }
                        Console.WriteLine();
                    }
                    else if (commands[0] == "Show")
                    {
                        int index = int.Parse(commands[1]);
                        Console.WriteLine(nums[index]);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    count++;
                }
                catch (FormatException fex) 
                {
                    Console.WriteLine("The variable is not in the correct format!");

                    count++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    count++;
                }

                if(count >= 3)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}