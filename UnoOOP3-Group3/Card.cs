using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoOOP3_Group3
{
    // Class represents a playing card with color and value
    public class Card
    {
        // Getters and setters to store the color and value of a card
        public CardColor Color { get;  set; }
        public CardValue Value { get;  set; }

        // Constructor of card class with color and value attributes  
        public Card(CardColor color, CardValue value)
        {
            Color = color;
            Value = value;
        }

        // Enumeration of the possbile card colors in CardColor
        public enum CardColor
        {
            Red, Green, Blue, Yellow, Wild
        }

        // Enumeration of the possbile card values in CardValue
        public enum CardValue
        {
            Zero = 0, One, Two, Three, Four, Five, Six, Seven, Eight, Nine,
            Skip, Reverse, DrawTwo, Wild, WildDrawFour
        }

        // Overide toString output a string representing a card
        public override string ToString()
        {
            return $"{Color} {Value}";
        }
    }
}
