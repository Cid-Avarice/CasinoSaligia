using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.DeckOfCards;
using Blackjack.Payout;

namespace Blackjack.Player
{
    abstract class BlackjackPlayer : IBlackjackPlayer
    {
        private List<ICard> _hand;
        private string _name = "";
        private decimal _bet = 0.0M;
        private int _handValue = 0;
        private decimal _currentAmount = 0.0M;

        /// <summary>
        /// Constructor
        /// </summary>
        public BlackjackPlayer(ICard card1, ICard card2, decimal currentAmount) 
        {
            _hand = new List<ICard> { card1, card2 };
            //HandValue = DetermineLogic.DetermineHandValue(_hand);
            _currentAmount = currentAmount;
        }

        /// <summary>
        /// Name of player
        /// </summary>
        /// <returns></returns>
        public string Name
        {
            get { return _name;  }
            set { _name = value; }
        }

        /// <summary>
        /// Receives a card
        /// </summary>
        /// <param name="card1">Card.</param>
        public void ReceiveCard(ICard card)
        {
            _hand.Add(card);
            //HandValue = DetermineLogic.DetermineHandValue(_hand);
        }

        /// <summary>
        /// Hand of the player
        /// </summary>
        /// <returnsList of cards.</returns>
        public List<ICard> Hand()
        {
            return _hand;
        }

        /// <summary>
        /// Getter and setter for player's total cash amount.
        /// </summary>
        public decimal TotalCash 
        { 
            get { return _currentAmount; }
            set { _currentAmount = value; }
        }

        /// <summary>
        /// Players are distinct by their name.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            var otherPlayer = (IBlackjackPlayer)other;
            return otherPlayer.Name.Equals(_name);
        }

        /// <summary>
        /// Returns te value of the hand for this player
        /// </summary>
        /// <returns>Value of hand</returns>
        public int HandValue
        {
            get { return _handValue; }
            set { _handValue = value; }
        }

        /// <summary>
        /// Getter and setter for the player's bet.
        /// </summary>
        public decimal Bet
        {
            get { return _bet; }
            set { _bet = value; }
        }

        /// <summary>
        /// Name of the player
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _name;
        }
    }
}
