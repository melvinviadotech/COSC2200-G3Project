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
        private static Player[] players = { new Player("Player"), new Player("Computer")};
        private Game game = new Game(players);
        private Card selectedCard; // Track the currently selected card
        private Bitmap spriteSheet;
        private Bitmap spriteSheetBitmap;
        
        public frmMain()
        {
            InitializeComponent();

            //spriteSheet = Properties.Resources.UNO_Front;
        }
        //#region Card Button
        //private void CardButton_Click(object sender, EventArgs e)
        //{
        //    var cardButton = sender as Button;
        //    var card = (Card)cardButton.Tag;

        //    // Select the card
        //    selectedCard = card;
        //    HighlightCardButton(cardButton);
        //}

        //// Method to handle double click on card button to play the card
        //private void CardButton_DoubleClick(object sender, EventArgs e)
        //{
        //    var cardButton = sender as Button;
        //    var card = (Card)cardButton.Tag;

        //    // Check if the double-clicked card is the same as the selected card
        //    if (card == selectedCard)
        //    {
        //        // Play the selected card
        //        game.PlayCard(currentPlayer, selectedCard);
        //        UpdateUI();
        //    }
        //}

        //// Method to highlight the selected card button for visual feedback
        //private void HighlightCardButton(Button cardButton)
        //{
        //    // Clear highlights from all card buttons first
        //    foreach (Button btn in flowLayoutPlayersHand.Controls)
        //    {
        //        btn.BackColor = Color.Transparent;
        //    }

        //    // Highlight the selected button
        //    cardButton.BackColor = Color.LightBlue; // Or any highlight color
        //}
        //#endregion
        //private const int CardWidth = 406;  // Width of a single card
        //private const int CardHeight = 586; // Height of a single card

        //private Point GetCardCoordinates(Card card)
        //{
        //    int columnIndex = 0;
        //    int rowIndex = 0;

        //    switch (card.Color)
        //    {
        //        case Card.CardColor.Red:
        //            rowIndex = 0; // Red is in the first row
        //            break;
        //        case Card.CardColor.Yellow:
        //            rowIndex = 1; // Yellow is in the second row
        //            break;
        //        case Card.CardColor.Blue:
        //            rowIndex = 2; // Blue is in the third row
        //            break;
        //        case Card.CardColor.Green:
        //            rowIndex = 3; // Green is in the fourth row
        //            break;
        //    }


        //    if (card.Value == Card.CardValue.Wild || card.Value == Card.CardValue.WildDrawFour)
        //    {
        //        // Wild cards are in the last spot of rows 1 and 2
        //        // +4 cards are in the last spot of rows 3 and 4
        //        columnIndex = 9;
        //    }
        //    else if (card.Value == Card.CardValue.Skip || card.Value == Card.CardValue.DrawTwo || card.Value == Card.CardValue.Reverse)
        //    {
        //        // Cancel (+) and Reverse cards are in row 5
        //        rowIndex = 4;
        //        if (card.Value == Card.CardValue.Skip)
        //        {
        //            columnIndex = (card.Color == Card.CardColor.Red || card.Color == Card.CardColor.Yellow) ? 0 : 5;
        //        }
        //        else if (card.Value == Card.CardValue.DrawTwo)
        //        {
        //            columnIndex = (card.Color == Card.CardColor.Red) ? 4 :
        //                          (card.Color == Card.CardColor.Yellow) ? 5 :
        //                          (card.Color == Card.CardColor.Blue) ? 6 : 7;
        //        }
        //        else if (card.Value == Card.CardValue.Reverse)
        //        {
        //            columnIndex = (card.Color == Card.CardColor.Red) ? 8 :
        //                          (card.Color == Card.CardColor.Yellow) ? 9 :
        //                          (card.Color == Card.CardColor.Blue) ? 10 : 11;
        //        }
        //    }
        //    else
        //    {
        //        // Numeric cards are in columns 1-9 based on their number
        //        columnIndex = (int)card.Value - 1;
        //    }

        //    // Calculate the X and Y coordinates
        //    int x = columnIndex * CardWidth;
        //    int y = rowIndex * CardHeight;

        //    return new Point(x, y);
        //}
        //private Image CropImageFromSpriteSheet(Bitmap spriteSheet, Point coordinates, Size cardSize)
        //{
        //    Rectangle cropArea = new Rectangle(coordinates, cardSize);
        //    Bitmap croppedImage = new Bitmap(cropArea.Width, cropArea.Height);

        //    using (Graphics g = Graphics.FromImage(croppedImage))
        //    {
        //        g.DrawImage(spriteSheet, new Rectangle(0, 0, cardSize.Width, cardSize.Height),
        //                    cropArea, GraphicsUnit.Pixel);
        //    }

        //    return croppedImage;
        //}
        //private Image GetCardImage(Card card)
        //{
        //    if (card.Color == Card.CardColor.Wild && card.Value == Card.CardValue.Wild)
        //    {
        //        return Properties.Resources.UNO_Back; // Wild card image
        //    }
        //    else if (card.Color == Card.CardColor.Wild && card.Value == Card.CardValue.WildDrawFour)
        //    {
        //        return Properties.Resources.UNO_Back; // Wild Draw Four card image
        //    }
        //    else
        //    {
        //        // Calculate the position of the card image in the sprite sheet
        //        Point cardPosition = GetCardCoordinates(card);
        //        // Crop the card image from the sprite sheet
        //        return CropImageFromSpriteSheet(spriteSheet, cardPosition, new Size(406, 586));
        //    }
        //}
        //private void UpdateUI()
        //{


        //}

        //private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

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

            // Get selected card
            Card selectedCard = Game.currentPlayer.Hand[selectedIndex];
            pictureBox1.Image = selectedCard.Image;

            // Try to play selected card
            if (Game.PlayCard(Game.currentPlayer, selectedCard))
            {
                RefreshDiscardHand();

                RefreshPlayerHand();

                playMessage.Text = "Card played";

                Game.PassTurn();
            }           
            // Play of card was unsuccessful
            else
            {
                playMessage.Text = "You cannot play that card!";
            }
        }

        private void DrawCard(object sender, EventArgs e)
        {
            Game.currentPlayer.Hand.Add(Deck.Draw());

            RefreshPlayerHand();

            // Next turn
            Game.PassTurn();

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

            // Use the selected index to get the corresponding card from the player's hand
            Card selectedCard = Game.currentPlayer.Hand[selectedIndex];

            // Display the image of the selected card in the PictureBox
            pictureBox1.Image = selectedCard.Image;
        }
    }
}
