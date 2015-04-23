using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.DeckOfCards
{
    class Card : ICard
    {
        private string _face;
        private string _suit;
        private int _value;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="suit">Suit of the card.</param>
        /// <param name="face">Face of the card.</param>
        public Card(string suit, string face)
        {
            this.Face = face;
            this.Suit = suit;
            this.Value = ValueOfCard.ReturnValue(face);
        }

        public string Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public string Face
        {
            get { return _face; }
            set { _face = value; }
        }

        public override string ToString()
        {
            return _face + " of " + _suit;
        }

        public override bool Equals(object other)
        {
            var otherCard = (Card)other;
            return otherCard.Suit.Equals(_suit) && otherCard.Face.Equals(_face);
        }
    }
}
