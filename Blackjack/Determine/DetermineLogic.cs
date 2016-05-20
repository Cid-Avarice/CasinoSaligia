using Blackjack.DeckOfCards;
using Blackjack.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Payout
{
    class DetermineLogic
    {
        public int DetermineHandValue(List<ICard> hand)
        {
            var value = 0;
            bool containsAce = false;
            foreach(var card in hand)
            {
                if (card.Value == 1 && !containsAce)
                {
                    value += 11;
                    containsAce = true;
                }
                else
                    value += card.Value;
            }

            if (containsAce && value > 21)
                value -= 10;

            return value;
        }

        public IBlackjackPlayer DetermineWinner(IBlackjackPlayer player1, IBlackjackPlayer player2)
        {
            if (player1.HandValue > player2.HandValue)
                return player1;
            if (player1.HandValue < player2.HandValue)
                return player2;
            return null;
        }

        public decimal DeterminePayout(IBlackjackPlayer player, bool isBlackJack)
        {
            if (isBlackJack)
                return player.Bet * 1.5M;
            return player.Bet;
        }
    }
}
