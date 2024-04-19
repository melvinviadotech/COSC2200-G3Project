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
            var topCard = Game.discardPile.LastOrDefault(); // Get the top card from the discard pile.
            var cardToPlay = ChooseCardToPlay(topCard, Game.deck); // Determine the best card to play.

            if (cardToPlay != null)
            {
                // If a card can be played, play the card.
                if (game.PlayCard(this, cardToPlay))
                {
                    // If the card is a Wild or Wild Draw Four, choose a color.
                    if (cardToPlay.Value == CardValue.Wild || cardToPlay.Value == CardValue.WildDrawFour)
                    {
                        bool isHumanPlayer = !this.IsComputer; // Determine if the player is human
                        cardToPlay.CurrentColor = ChooseColor(isHumanPlayer);
                    }
                }
            }
            else
            {
                // If no card is playable, draw a card from the deck.
                DrawCard(Game.deck);
                cardToPlay = Hand.LastOrDefault(); // Get the last drawn card.

                // Try to play the newly drawn card if it's playable.
                if (IsPlayable(cardToPlay, topCard))
                {
                    game.PlayCard(this, cardToPlay);
                    if (cardToPlay.Value == CardValue.Wild || cardToPlay.Value == CardValue.WildDrawFour)
                    {
                        bool isHumanPlayer = !this.IsComputer; // Determine if the player is human
                        cardToPlay.CurrentColor = ChooseColor(isHumanPlayer);
                    }
                }
            }

        }

        public CardColor ChooseColor(bool isHuman) 
        {
            if(isHuman)
            {
                WildCardPopUp wildCard = new WildCardPopUp();

                wildCard.ShowDialog();

                if (wildCard.wildRedClicked == true) { return CardColor.Red; }
                else if (wildCard.wildGreenClicked == true) { return CardColor.Green; }
                else if (wildCard.wildBlueClicked == true) { return CardColor.Blue; }
                else { return CardColor.Yellow; }
            }
            else
            {
                // If it's the computer's turn, choose a random color
                Random random = new Random();
                int randomNumber = random.Next(0, 4);// 1-4 to correspond with the four colors
                return (CardColor)randomNumber;
            }
            
            
        }


    }
}
