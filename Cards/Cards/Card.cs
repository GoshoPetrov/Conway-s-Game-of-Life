using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Cardssss
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

            string[] validFaces = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

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
}
