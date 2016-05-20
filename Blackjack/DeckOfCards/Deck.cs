using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.DeckOfCards
{
    class Deck
    {
        public List<ICard> deck = new List<ICard>();

        /// <summary>
        /// Initializes deck of 52 cards
        /// </summary>
        public void CreateDeck()
        {
            EmptyDeck();

            for(int i = 0; i < 4; i++)
            {
                string suit;
                switch(i)
                {
                    case 0: suit = "Spades"; break;
                    case 1: suit = "Hearts"; break;
                    case 2: suit = "Clubs"; break;
                    case 3: suit = "Diamonds"; break;
                    default:
                        throw new Exception("Incorrect suit created for a card!");
                }

                deck.Add(new Card(suit, "Ace"));
                deck.Add(new Card(suit, "Two"));
                deck.Add(new Card(suit, "Three"));
                deck.Add(new Card(suit, "Four"));
                deck.Add(new Card(suit, "Five"));
                deck.Add(new Card(suit, "Six"));
                deck.Add(new Card(suit, "Seven"));
                deck.Add(new Card(suit, "Eight"));
                deck.Add(new Card(suit, "Nine"));
                deck.Add(new Card(suit, "Ten"));
                deck.Add(new Card(suit, "Jack"));
                deck.Add(new Card(suit, "Queen"));
                deck.Add(new Card(suit, "King"));
            }
        }

        /// <summary>
        /// Draws a random card from the deck
        /// </summary>
        /// <returns>Random card</returns>
        public ICard DrawCard()
        {
            if (deck.Count == 0)
                Reshuffle();

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

        /// <summary>
        /// Empties the deck
        /// </summary>
        public void EmptyDeck()
        {
            deck = new List<ICard>();
        }
    }
}
