using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UnoOOP3_Group3.Card;

namespace UnoOOP3_Group3
{
    public partial class frmMain : Form
    {
        private static Player[] players /*= { new Player("Player"), new Player("Computer")}*/;
        private Game game /*= new Game(players)*/;
        private Card selectedCard; // Track the currently selected card
        private void InitializeGame()
        {
            // Initialize players
            Player humanPlayer = new Player("Human");
            Player computerPlayer = new Player("Computer", isComputer: true);

            players = new Player[] { humanPlayer, computerPlayer };
            game = new Game(players);

            // Set up the rest of the UI or game state as needed
        }

        public frmMain()
        {
            InitializeComponent();
            InitializeGame();


        }
       
        // Close the game
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Help Menu Strip
        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructions instructions = new Instructions();
            instructions.ShowDialog();
        }

        private void technicalSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechSupport technicalSupport = new TechSupport();
            technicalSupport.ShowDialog();
        }

        private void aboutUNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUno about = new AboutUno();
            about.ShowDialog(); 
        }
        #endregion

        // Melvin Viado Section
        public void StartGame(object sender, EventArgs e)
        {
            // Start the game on start game button click
            game.StartGame();

            // Close the start Game Button
            startGameButton.Enabled = false;

            var firstElement = Game.discardPile.First();

            // Display discard pile
            discardPile.Items.Add(firstElement.Color + " " + firstElement.Value);

            currentTurn.Text = Game.currentPlayer.Name;

            // Display player hand
            foreach (Card card in Game.players[0].Hand)
            {
                playerHand.Items.Add(card.Color + " " + card.Value); 
            }

            // Display computer hand
            foreach (Card card in Game.players[1].Hand)
            {
                computerHand.Items.Add(card.Color + " " + card.Value);
            }
        }

        private void PlayCard(object sender, EventArgs e)
        {
            // Get index of selected card in hand
            int selectedIndex = playerHand.SelectedIndex;
            // Check if a card is selected
            if (selectedIndex != -1)
            {
                // Get selected card
                Card selectedCard = Game.currentPlayer.Hand[selectedIndex];
                pictureBox1.Image = selectedCard.Image;

                // Try to play selected card
                if (game.PlayCard(Game.currentPlayer, selectedCard))
                {
                    RefreshDiscardHand();

                    RefreshPlayerHand();

                    playMessage.Text = "Card played";

                    game.PassTurn();
                }           
                // Play of card was unsuccessful
                else
                {
                    playMessage.Text = "You cannot play that card!";
                }
                }
            else
            {
                playMessage.Text = "No card selected!";
            }
        }

        private void DrawCard(object sender, EventArgs e)
        {
            Game.currentPlayer.Hand.Add(Deck.Draw());

            RefreshPlayerHand();

            // Next turn
            game.PassTurn();

            // Update current turn 
            currentTurn.Text = Game.currentPlayer.Name;
        }

        // Re-display player hand
        private void RefreshPlayerHand()
        {
            playerHand.Items.Clear();
            foreach (Card card in Game.players[0].Hand)
            {
                playerHand.Items.Add(card.Color + " " + card.Value);
            }
        }

        // Re-display discard pile
        private void RefreshDiscardHand()
        {
            discardPile.Items.Clear();
            foreach (Card card in Game.discardPile)
            {
                discardPile.Items.Add(card.Color + " " + card.Value);
            }
        }

        private void playerHand_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected index from the ListBox
            int selectedIndex = playerHand.SelectedIndex;
            // Check if an item is selected in the ListBox
            if (selectedIndex != -1 && selectedIndex < Game.currentPlayer.Hand.Count)
            {
                // Use the selected index to get the corresponding card from the player's hand
                Card selectedCard = Game.currentPlayer.Hand[selectedIndex];

                // Display the image of the selected card in the PictureBox
                pictureBox1.Image = selectedCard.Image;
            }
        }
    }
}
