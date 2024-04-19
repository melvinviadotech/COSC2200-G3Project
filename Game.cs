using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnoOOP3_Group3.Card;

namespace UnoOOP3_Group3
{
    public class Game
    {
        public static Deck deck;
        public static List<Card> discardPile;
        public static Player[] players;
        public static Player currentPlayer;
        public static bool isGameRunning;

        public Game(Player[] gamePlayers)
        {
            players = gamePlayers;
            deck = new Deck();
            discardPile = new List<Card>();
            currentPlayer = players[0];
            isGameRunning = true;
        }

        public void StartGame()
        {

            // Shuffle the deck and deal 7 cards to each player
            deck.Shuffle();
            foreach (Player player in players)
            {
                player.Hand.AddRange(deck.DrawCards(7));
            }
            Card firstCard = Deck.Draw();

            // Flip the top card to start the discard pile
            discardPile.Add(firstCard);            

            // Determine the starting player and current color
            currentPlayer = players[0];
            if (firstCard.Color == Card.CardColor.Wild)
            {
                firstCard.Color = currentPlayer.ChooseColor();
            }

            // Start the game
            isGameRunning = true;
        }

        public  bool PlayCard(Player player, Card card)
        {
            if (player.Hand.Contains(card) && IsPlayable(card))
            {
                player.Hand.Remove(card); // Remove the card from the player's hand.
                discardPile.Add(card);   // Add the card to the discard pile.

                ApplyCardEffect(card);   // Apply any effects based on the card's value.

                // Check if the player has won the game (no more cards left).
                if (player.Hand.Count == 0)
                {
                    EndGame(player);
                    return true;
                }

                // If the card is not a Skip or Reverse, pass the turn.
                if (card.Value != CardValue.Skip && card.Value != CardValue.Reverse)
                {
                    PassTurn();
                }

                return true; // Card was successfully played.
            }

            // If the card is not in the player's hand or is not playable, return false.
            return false;
        }

        private static bool IsPlayable(Card card)
        {
            Card topCard = discardPile.LastOrDefault();
            if (topCard == null)
            {
                // If the discard pile is empty, any card can be played (shouldn't happen if game is started correctly)
                return true;
            }
            // Handle wild card colors
            if (topCard.Color == CardColor.Wild && topCard.CurrentColor.HasValue)
            {
                return card.Color == topCard.CurrentColor.Value || card.Color == CardColor.Wild;
            }
            // Check if the card to be played matches the top card in color, value, or is a wild card
            return topCard != null && (card.Color == topCard.Color || card.Value == topCard.Value || card.Color == CardColor.Wild || topCard.Color == CardColor.Wild);
        }

        private void ApplyCardEffect(Card card)
        {
            // Example of applying effects based on the card value
            switch (card.Value)
            {
                case CardValue.Skip:
                    // Skip the next player's turn
                    SkipTurn();
                    PassTurn();
                    break;
                case CardValue.Reverse:
                    // Reverse the order of play
                    Array.Reverse(players);
                    PassTurn();
                    break;
                case CardValue.DrawTwo:
                    // Next player draws two cards
                    SkipTurn();
                    currentPlayer.Hand.AddRange(deck.DrawCards(2));
                    break;
                // Handle other card effects, such as wild cards
                case CardValue.Wild:
                    card.Color = currentPlayer.ChooseColor();
                    PassTurn();
                    break;
                case CardValue.WildDrawFour:
                    card.Color = currentPlayer.ChooseColor();
                    SkipTurn();
                    currentPlayer.Hand.AddRange(deck.DrawCards(4));
                    break;
            }
            // TODO: Update the game state 
        }

  /*      public static void PassTurn()
        {
            // Move the turn to the next player in the sequence
            //int currentPlayerIndex = Array.IndexOf(players, currentPlayer);
            //currentPlayer = players[(currentPlayerIndex + 1) % players.Length];

            // Simpler logic to go to next player
            if (currentPlayer == players[0])
            {
                currentPlayer = players[1];
            } 
            else
            {
                currentPlayer = players[0];
            }
        }*/
        public void PassTurn()
        {
            // logic for passing the turn
            int currentPlayerIndex = Array.IndexOf(players, currentPlayer);
            currentPlayer = players[(currentPlayerIndex + 1) % players.Length];

            // If the next player is the computer, call TakeTurn()
            if (currentPlayer.IsComputer)
            {
                currentPlayer.TakeTurn(this);
            }
        }

        // Method just for skipping a turn without
        public void SkipTurn()
        {
            // logic for passing the turn
            int currentPlayerIndex = Array.IndexOf(players, currentPlayer);
            currentPlayer = players[(currentPlayerIndex + 1) % players.Length];

        }

        private static void EndGame(Player winner)
        {
            // Handle the end of the game, declaring the winner
            Console.WriteLine($"{winner.Name} has won the game!");
            isGameRunning = false;
        }
    }
}
