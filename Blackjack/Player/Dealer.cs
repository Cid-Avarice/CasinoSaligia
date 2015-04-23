using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.DeckOfCards;

namespace Blackjack.Player
{
    class Dealer : IPlayer
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Dealer() { }

        /// <summary>
        /// Name of player
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Dealer";
        }
    }
}
