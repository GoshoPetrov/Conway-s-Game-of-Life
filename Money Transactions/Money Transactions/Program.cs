namespace Money_Transactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> bankStuff = new Dictionary<int, double>();

            string[] banks = Console.ReadLine().Split(",");

            foreach(var item in banks)
            {
                string[] arr = item.Split("-");

                int accountNum = int.Parse(arr[0]);
                double sum = double.Parse(arr[1]);

                bankStuff.Add(accountNum, sum);
            }

            while (true)
            {
                try
                {
                    string[] command = Console.ReadLine().Split();

                    if (command[0] == "End")
                    {
                        break;
                    }

                    if (command[0] == "Deposit")
                    {
                        int acountNum = int.Parse(command[1]);
                        if (!bankStuff.ContainsKey(acountNum))
                        {
                            throw new Exception("Invalid account!");
                        }
                        double sum = double.Parse(command[2]);

                        bankStuff[acountNum] += sum;
                        Console.WriteLine($"Account {acountNum} has new balance: {bankStuff[acountNum]:F02}");
                    }
                    else if (command[0] == "Withdraw")
                    {
                        int acountNum = int.Parse(command[1]);
                        if (!bankStuff.ContainsKey(acountNum))
                        {
                            throw new Exception("Invalid account!");
                        }
                        double sum = double.Parse(command[2]);

                        if (bankStuff[acountNum] < sum)
                        {
                            throw new Exception("Insufficient balance!");
                        }

                        bankStuff[acountNum] -= sum;

                        Console.WriteLine($"Account {acountNum} has new balance: {bankStuff[acountNum]:F02}");
                    }
                    else
                    {
                        throw new Exception("Invalid command!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                Console.WriteLine("Enter another command");
            }
        }
    }
}