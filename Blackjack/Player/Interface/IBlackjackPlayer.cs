using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.DeckOfCards;

namespace Blackjack.Player
{
    interface IBlackjackPlayer
    {
        /// <summary>
        /// Name of the player
        /// </summary>
        /// <returns></returns>
        string Name { get; set; }

        /// <summary>
        /// Receives a card
        /// </summary>
        /// <param name="card1">Card.</param>
        void ReceiveCard(ICard card);

        /// <summary>
        /// Hand of the player
        /// </summary>
        /// <returnsList of cards.</returns>
        List<ICard> Hand();

        /// <summary>
        /// Getter and setter for the players bet
        /// </summary>
        decimal Bet { get; set; }

        /// <summary>
        /// Getter and setter for player's total cash amount.
        /// </summary>
        decimal TotalCash { get; set; }

        /// <summary>
        /// Returns te value of the hand for this player
        /// </summary>
        /// <returns>Value of hand</returns>
        int HandValue { get; set; }
    }
}
