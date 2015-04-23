using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.DeckOfCards;

namespace Blackjack.Player
{
    interface IPlayer
    {
        private ICard _card1;
        private ICard _card2;

        /// <summary>
        /// Name of the player
        /// </summary>
        /// <returns></returns>
        string Name();

        /// <summary>
        /// Receives the hand
        /// </summary>
        /// <param name="card1">First card.</param>
        /// <param name="card2">Second card.</param>
        void ReceiveHand(ICard card1, ICard card2)
        {
            _card1 = card1;
            _card2 = card2;
        }

        /// <summary>
        /// Hand of the player
        /// </summary>
        /// <returns>Tuple of 2 cards.</returns>
        Tuple<ICard, ICard> Hand()
        {
            if(_card1 != null && _card2 != null)
                return new Tuple<ICard, ICard>(_card1, _card2);

            throw new Exception("The hand of " + Name() + " is missing a card!");
        }

        /// <summary>
        /// Players are distinct by their name.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        override bool Equals(object other)
        {
            var oth = (IPlayer)other;
            return oth.Name().Equals(this.Name());
        }

        public int HandValue()
        {
            return 0;
        }

        /// <summary>
        /// Name of the player
        /// </summary>
        /// <returns></returns>
        override string ToString() 
        {
            return Name();
        }
    }
}
