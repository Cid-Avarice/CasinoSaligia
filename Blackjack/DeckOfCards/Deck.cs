using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.DeckOfCards
{
    class Deck
    {
        private List<ICard> deck = new List<ICard>();
     
        /// <summary>
        /// Constructor
        /// </summary>
        public Deck()
        {
            CreateDeck();
        }

        /// <summary>
        /// Initializes deck of 52 cards
        /// </summary>
        private void CreateDeck()
        {
            for(int i = 0; i < 4; i++)
            {
                string suit;
                switch(i)
                {
                    case 0: suit = "spades"; break;
                    case 1: suit = "hearts"; break;
                    case 2: suit = "clubs"; break;
                    case 3: suit = "diamonds"; break;
                    default:
                        throw new Exception("Incorrect suit created for a card!");
                }

                deck.Add(new Card(suit, "ace"));
                deck.Add(new Card(suit, "two"));
                deck.Add(new Card(suit, "three"));
                deck.Add(new Card(suit, "four"));
                deck.Add(new Card(suit, "five"));
                deck.Add(new Card(suit, "six"));
                deck.Add(new Card(suit, "seven"));
                deck.Add(new Card(suit, "eight"));
                deck.Add(new Card(suit, "nine"));
                deck.Add(new Card(suit, "ten"));
                deck.Add(new Card(suit, "jack"));
                deck.Add(new Card(suit, "queen"));
                deck.Add(new Card(suit, "king"));
            }
        }

        /// <summary>
        /// Draws a random card from the deck
        /// </summary>
        /// <returns>Random card</returns>
        public ICard DrawCard()
        {
            if (deck.Count == 0)
                throw new Exception("Drawing a card from an empty deck!");

            Random rnd = new Random();

            int card = rnd.Next(deck.Count);

            var selectedCard = deck[card];

            deck.Remove(selectedCard);

            return selectedCard;
        }

        /// <summary>
        /// Resets deck
        /// </summary>
        public void Reshuffle()
        {
            CreateDeck();
        }
    }
}
