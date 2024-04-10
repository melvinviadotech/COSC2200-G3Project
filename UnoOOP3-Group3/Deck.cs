using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnoOOP3_Group3.Card;

namespace UnoOOP3_Group3
{
    // Class represents a deck with random cards
    public class Deck
    {
        // Create list to hold cards
        private List<Card> cards;

        // Initalize the random number generation 
        private Random random;

        // Constructor of Deck class that creates a deck of random cards and shuffles them
        public Deck()
        {
            cards = new List<Card>();
            random = new Random();
            CreateDeck();
            Shuffle();
        }

        // Method to create deck of uno cards
        private void CreateDeck()
        {
            // Standard UNO cards
            foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
            {
                if (color == CardColor.Wild) continue; // Skip wild color for now

                // One zero card per color
                cards.Add(new Card(color, CardValue.Zero));

                // Two of each number for each color
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    if (value == CardValue.Zero || value > CardValue.Nine) continue; // Skip zero and special cards for now

                    cards.Add(new Card(color, value));
                    cards.Add(new Card(color, value));
                }

                // Two Skip, Reverse, DrawTwo for each color
                cards.Add(new Card(color, CardValue.Skip));
                cards.Add(new Card(color, CardValue.Skip));
                cards.Add(new Card(color, CardValue.Reverse));
                cards.Add(new Card(color, CardValue.Reverse));
                cards.Add(new Card(color, CardValue.DrawTwo));
                cards.Add(new Card(color, CardValue.DrawTwo));
            }

            // Wild and Wild Draw Four cards
            for (int i = 0; i < 4; i++)
            {
                cards.Add(new Card(CardColor.Wild, CardValue.Wild));
                cards.Add(new Card(CardColor.Wild, CardValue.WildDrawFour));
            }
        }

        // Method for shuffling deck
        public void Shuffle()
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int swapIndex = random.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[swapIndex];
                cards[swapIndex] = temp;
            }
        }

        // Method for drawing a card from the deck
        public Card Draw()
        {
            if (cards.Count == 0)
                throw new InvalidOperationException("Cannot draw from an empty deck.");

            Card drawnCard = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return drawnCard;
        }

        // Method for drawing multiple cards from the deck
        public List<Card> DrawCards(int numberOfCards)
        {
            List<Card> drawnCards = new List<Card>();
            for (int i = 0; i < numberOfCards; i++)
            {
                drawnCards.Add(Draw()); // Assumes Draw() removes the card from the deck
            }
            return drawnCards;
        }

    }
}
