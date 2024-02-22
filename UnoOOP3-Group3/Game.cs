using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnoOOP3_Group3.Card;

namespace UnoOOP3_Group3
{
    public class Game
    {
        private Deck deck;
        private List<Card> discardPile;
        private Player[] players;
        private Player currentPlayer;
        private bool isGameRunning;

        public Game(Player[] players)
        {
            this.players = players;
            deck = new Deck();
            discardPile = new List<Card>();
            currentPlayer = players[0];
            isGameRunning = true;
            StartGame();
        }
        private void StartGame()
        {
            // Shuffle the deck and deal 7 cards to each player
            deck.Shuffle();
            foreach (Player player in players)
            {
                player.Hand.AddRange(deck.DrawCards(7));
            }
            Card firstCard = deck.Draw();
            // Flip the top card to start the discard pile
            discardPile.Add(deck.Draw());

            // Determine the starting player and current color
            currentPlayer = players[0];
            if (firstCard.Color == Card.CardColor.Wild)
            {
                firstCard.Color = currentPlayer.ChooseColor();
            }

            // Start the game
            isGameRunning = true;
        }

        public bool PlayCard(Player player, Card card)
        {
            // Check if the card is in the player's hand and if the play is legal
            if (player.Hand.Contains(card) && IsPlayable(card))
            {
                // Remove the card from the player's hand
                player.Hand.Remove(card);

                // Add the card to the top of the discard pile
                discardPile.Add(card);

                // Apply the effect of the card to the game
                ApplyCardEffect(card);

                // Check for a winning condition
                if (player.Hand.Count == 0)
                {
                    EndGame(player);
                    return true;
                }

                // If the card is not a Skip or a Reverse, pass the turn to the next player
                if (card.Value != CardValue.Skip && card.Value != CardValue.Reverse)
                {
                    PassTurn();
                }

                // Return true to indicate that the card was played successfully
                return true;
            }
            else
            {
                // If the play is not legal or the card is not in the player's hand, return false
                return false;
            }
        }

        private bool IsPlayable(Card card)
        {
            Card topCard = discardPile.LastOrDefault();
            if (topCard != null)
            {
                // Check if the card to be played matches the top card in color, value, or is a wild card
                return card.Color == topCard.Color || card.Value == topCard.Value || card.Color == CardColor.Wild;
            }
            // If the discard pile is empty, any card can be played (shouldn't happen if game is started correctly)
            return true;
        }

        private void ApplyCardEffect(Card card)
        {
            // Example of applying effects based on the card value
            // You'll need to fill in the specific effects for each card type
            switch (card.Value)
            {
                case CardValue.Skip:
                    // Skip the next player's turn
                    break;
                case CardValue.Reverse:
                    // Reverse the order of play
                    break;
                case CardValue.DrawTwo:
                    // Next player draws two cards
                    break;
                    // Handle other card effects, such as wild cards
            }
            // TODO: Update the game state 
        }

        private void PassTurn()
        {
            // Move the turn to the next player in the sequence
            int currentPlayerIndex = Array.IndexOf(players, currentPlayer);
            currentPlayer = players[(currentPlayerIndex + 1) % players.Length];
        }

        private void EndGame(Player winner)
        {
            // Handle the end of the game, declaring the winner
            Console.WriteLine($"{winner.Name} has won the game!");
            isGameRunning = false;
        }
    }
}
