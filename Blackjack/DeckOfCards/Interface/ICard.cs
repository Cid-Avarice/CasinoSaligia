using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.DeckOfCards
{
    interface ICard
    {
        string Suit { get;  set; }
        int Value { get;  set; }
        string Face { get;  set; }
    }
}
