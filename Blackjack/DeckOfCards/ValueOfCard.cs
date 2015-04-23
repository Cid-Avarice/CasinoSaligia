using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.DeckOfCards
{
    class ValueOfCard
    {
        public static int ReturnValue(string face)
        {
            switch (face.ToLower())
            {
                case "ace" :  return 1;
                case "two": return 2;
                case "three": return 3;
                case "four": return 4;
                case "five": return 5;
                case "six": return 6;
                case "seven": return 7;
                case "eight": return 8;
                case "nine": return 9;
                case "ten": return 10;
                case "jack": return 10;
                case "queen": return 10;
                case "king": return 10;
                default:
                    return 0;
            }
        }
    }
}
