namespace Cards
{
    internal class Card
    {
        public string Face { get; set; }

        public string Suit { get; set; }

        private Dictionary<string, string> symbols = new Dictionary<string, string>
        {
            { "S", "\u2660" },
            { "H", "\u2665" },
            { "D", "\u2666" },
            { "C", "\u2663" }
        };

        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;

            string[] validFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            if (!validFaces.Contains(face))
            {
                throw new Exception("Invalid card!");
            }


            if (!symbols.ContainsKey(suit))
            {
                throw new Exception("Invalid card!");
            }
        }
        public override string ToString()
        {

            return $"[{Face}{symbols[Suit]}]";
        }
    }

    internal class Cards
    {
        static void Main(string[] args)
        {
            string[] cards = Console.ReadLine().Split(", ");

            List<Card> allCards = new List<Card>();

            foreach(var item in cards)
            {
                string[] parts = item.Split();

                try
                {
                    Card card = new Card(parts[0], parts[1]);

                    allCards.Add(card);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(string.Join(" ", allCards));
        }
    }

}