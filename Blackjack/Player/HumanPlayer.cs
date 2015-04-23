using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Player
{
    class HumanPlayer : IPlayer
    {
        private int _money = 0;
        private string _name;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Inputted name</param>
        /// <param name="money">Amount of money to spend.</param>
        public HumanPlayer(int money, string name = null)
        {
            _money = money;

            if (name == null)
                _name = "Human Player " + Guid.NewGuid().GetHashCode();
            else
                _name = name;
        }

        /// <summary>
        /// Name of player
        /// </summary>
        /// <returns>Name</returns>
        public string Name()
        {
            return _name;
        }
    }
}
