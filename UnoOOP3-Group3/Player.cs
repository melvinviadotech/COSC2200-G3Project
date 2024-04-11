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

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public void DrawCard(Deck deck)
        {
            Card drawnCard = deck.Draw();
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
        public Card ChooseCardToPlay(Card topCard, Deck deck)
        {
            return null;
        }
        public CardColor ChooseColor() 
        { 
            WildCardPopUp wildCard = new WildCardPopUp();

            wildCard.ShowDialog();

            if (wildCard.wildRedClicked == true) { return CardColor.Red; }
            else if (wildCard.wildGreenClicked == true) { return CardColor.Green; }
            else if(wildCard.wildBlueClicked == true) { return CardColor.Blue; }
            else { return CardColor.Yellow; }
            
            
        }
    }
}
