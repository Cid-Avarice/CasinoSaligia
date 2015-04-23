using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.DeckOfCards
{
    interface ICard
    {
        string Suit();
        int Value();
        string Face();
        string ToString();
        bool Equals(object other);
    }
}
