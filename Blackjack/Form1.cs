using Blackjack.DeckOfCards;
using Blackjack.Payout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private Deck deck;
        private DetermineLogic logic;

        public Form1()
        {
            InitializeComponent();
            deck = new Deck();
            logic = new DetermineLogic();
            deck.CreateDeck();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var card1 = deck.DrawCard();
            var card2 = deck.DrawCard();

            var total = logic.DetermineHandValue(new List<ICard> { card1, card2 });

            textBox1.Text = "You've drawn:\r\n" + card1 + " and " + card2 + "\r\nfor a total value of " + total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deck.Reshuffle();
            textBox1.Text = "Deck reshuffled...";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
