using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnoOOP3_Group3.Card;

namespace UnoOOP3_Group3
{
    public class Player
    {
        public string Name { get; private set; }
        public List<Card> Hand { get; private set; }

        public bool IsComputer { get; private set; }

        public Player(string name, bool isComputer = false)
        {
            Name = name;
            Hand = new List<Card>();
            IsComputer = isComputer;
        }

        public void DrawCard(Deck deck)
        {
            Card drawnCard = Deck.Draw();
            Hand.Add(drawnCard);
        }

        public Card PlayCard(Card card)
        {
            if (Hand.Contains(card))
            {
                Hand.Remove(card);
                return card;
            }
            throw new InvalidOperationException("The card is not in the player's hand.");
        }
        private bool IsPlayable(Card card, Card topCard)
            {
            return card.Color == topCard.Color || card.Value == topCard.Value || card.Color == CardColor.Wild;
        }
        public Card ChooseCardToPlay(Card topCard, Deck deck)
        {
            // This method encapsulates the AI logic to choose a card to play
            // If no playable card is found, the computer should draw a card
            var playableCards = Hand.Where(card => IsPlayable(card, topCard)).ToList();

            // If there are playable cards, choose one 
            if (playableCards.Any())
            {
                // Prefer non-action cards first
                var preferredCard = playableCards
                    .OrderBy(card => card.Value >= CardValue.Skip ? 1 : 0)
                    .ThenByDescending(card => card.Value)
                    .FirstOrDefault();
                return preferredCard;
            }
            else
            {
                // If there are no playable cards, draw one and try to play it
                var drawnCard = Deck.Draw();
                Hand.Add(drawnCard);
                if (IsPlayable(drawnCard, topCard))
                {
                    return drawnCard;
                }
            }

            // If the drawn card is not playable or there were no playable cards, return null
            return null;
        }
        public void TakeTurn(Game game)
        {
            var topCard = Game.discardPile.LastOrDefault();
            var cardToPlay = ChooseCardToPlay(topCard, Game.deck);

            if (cardToPlay != null)
            {
                game.PlayCard(this, cardToPlay); // Play the chosen card
                if (cardToPlay.Value == CardValue.Wild || cardToPlay.Value == CardValue.WildDrawFour)
                {
                    // If the card is a Wild or Wild Draw Four, choose a color
                    cardToPlay.CurrentColor = ChooseColor();
                }
            }
            else
            {
                // If no card is played, draw one from the deck
                DrawCard(Game.deck);
            }
        }
        public CardColor ChooseColor() 
        {
            var colorCounts = Hand
           .Where(c => c.Color != CardColor.Wild)
           .GroupBy(c => c.Color)
           .OrderByDescending(group => group.Count())
           .FirstOrDefault();
            return colorCounts?.Key ?? CardColor.Red; // Default to Red if no colors are availabl
        }
    }
}
