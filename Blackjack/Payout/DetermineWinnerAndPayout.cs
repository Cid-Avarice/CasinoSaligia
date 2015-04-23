using Blackjack.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Payout
{
    class DetermineWinnerAndPayout
    {
        public static DetermineWinnerAndPayout instance;

        private DetermineWinnerAndPayout() { }

        public static DetermineWinnerAndPayout Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DetermineWinnerAndPayout();
                }
                return Instance;
            }
        }

        public IPlayer DetermineWinner(IPlayer player1, IPlayer player2)
        {
            if (player1.HandValue() > player2.HandValue())
                return player1;
            if (player1.HandValue() < player2.HandValue())
                return player2;
            return null;
        }

        public decimal DeterminePayout(IPlayer player, bool isBlackJack)
        {
            if (isBlackJack)
                return player.Bet * 1.5M;
            return player.Bet;
        }
    }
}
