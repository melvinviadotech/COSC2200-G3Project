using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // Add this line

using static UnoOOP3_Group3.Card;

namespace UnoOOP3_Group3
{
    // Class represents a deck with random cards
    public class Deck
    {
        // Create list to hold cards
        private static List<Card> cards;

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
            foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
            {
                if (color == CardColor.Wild) continue;

                cards.Add(new Card(color, CardValue.Zero, LoadImage(color, CardValue.Zero)));

                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    if (value == CardValue.Zero || value > CardValue.Nine) continue;

                    cards.Add(new Card(color, value, LoadImage(color, value)));
                    cards.Add(new Card(color, value, LoadImage(color, value)));
                }

                cards.Add(new Card(color, CardValue.Skip, LoadImage(color, CardValue.Skip)));
                cards.Add(new Card(color, CardValue.Skip, LoadImage(color, CardValue.Skip)));
                cards.Add(new Card(color, CardValue.Reverse, LoadImage(color, CardValue.Reverse)));
                cards.Add(new Card(color, CardValue.Reverse, LoadImage(color, CardValue.Reverse)));
                cards.Add(new Card(color, CardValue.DrawTwo, LoadImage(color, CardValue.DrawTwo)));
                cards.Add(new Card(color, CardValue.DrawTwo, LoadImage(color, CardValue.DrawTwo)));
            }

            for (int i = 0; i < 4; i++)
            {
                cards.Add(new Card(CardColor.Wild, CardValue.Wild, LoadImage(CardColor.Wild, CardValue.Wild)));
                cards.Add(new Card(CardColor.Wild, CardValue.WildDrawFour, LoadImage(CardColor.Wild, CardValue.WildDrawFour)));
            }
        }

        private Image LoadImage(CardColor color, CardValue value)
        {
            string imageName = $"{color.ToString().ToLower()}_{value.ToString().ToLower()}";
            return Properties.Resources.ResourceManager.GetObject(imageName) as Image;
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
        public static Card Draw()
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
