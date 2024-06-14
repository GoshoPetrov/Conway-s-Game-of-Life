namespace ConsoleApp10
{
    public class Account
    {
        public string Owner { get; set; }
        public double Balance { get; set; }

    }
    /// <summary>
    /// File.Read... Write...
    /// Lists - all the ways to construct a list
    /// By Value, By Reference
    /// string.Compare
    /// List operations
    ///     - rebuild with foreach
    ///     - create with ToList()
    ///     - fiter with Where(...)
    ///     - find item with Find
    ///     - Remove(...)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = File.ReadAllText(@"C:\Users\yan\Desktop\Conway-s-Game-of-Life\ConsoleApp10\ConsoleApp10\data.txt");

            string[] records = data.Split();

            var accountsByOwner = new Dictionary<string, Account>();
            foreach (var record in records)
            {
                try
                {
                    var columns = record.Split();
                    var account = new Account()
                    {
                        Owner = columns[0],
                        Balance = double.Parse(columns[1])
                    };

                    accountsByOwner.Add(account.Owner, account);
                } 
                catch (Exception ex)
                {
                    File.WriteAllLines(@"C:\Users\yan\Desktop\Conway-s-Game-of-Life\ConsoleApp10\ConsoleApp10\errors.log", new string[]
                    {
                        $"{DateTime.UtcNow} Error: {ex.Message}",
                    });
                }
                
            }


            // v1
            List<Account> allAccounts = new List<Account>();
            foreach (var kvp in accountsByOwner)
            {
                allAccounts.Add(kvp.Value);
            }

            // v2
            List<Account> allAccounts2 = new List<Account>(accountsByOwner.Values);

            // v3
            List<Account> allAccounts3 = accountsByOwner.Values.ToList();


            allAccounts.Sort((a, b) =>
            {
                int result = string.Compare(a.Owner, b.Owner);

                if (result == 0)
                {
                    if (a.Balance > b.Balance)
                    {
                        return -1;
                    }
                    if (a.Balance < b.Balance)
                    {
                        return 1;
                    }
                }

                return result;

            });

            // v1
            List<Account> rich = new List<Account>();
            // ...

            // v2
            List<Account> rich2 = accountsByOwner.Values.Where((x) =>
            {
                return x.Balance > 1000000;
            }).ToList();


            // all but putin
            // v1
            allAccounts3 = allAccounts3.Where((x) => x.Owner == "Putin").ToList();

            // v2 -- find and remove
            Account putin = allAccounts.Find((x) => x.Owner == "Putin");
            if (putin != null)
            {
                allAccounts3.Remove(putin);
            }

        }
    }
}