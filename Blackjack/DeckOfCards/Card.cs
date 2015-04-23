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
            _face = face;
            _suit = suit;
            _value = ValueOfCard.ReturnValue(face);
        }

        public string Suit()
        {
            return _suit;
        }

        public int Value()
        {
            return _value;
        }

        public string Face()
        {
            return _face;
        }

        public override string ToString()
        {
            return _face + " of " + _suit;
        }

        public override bool Equals(object other)
        {
            var otherCard = (Card)other;
            return otherCard.Suit().Equals(_suit) && otherCard.Face().Equals(_face);
        }
    }
}
