using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoOOP3_Group3
{
    public class Card
    {
        public CardColor Color { get;  set; }
        public CardValue Value { get;  set; }

        public Card(CardColor color, CardValue value)
        {
            Color = color;
            Value = value;
        }
        public enum CardColor
        {
            Red, Green, Blue, Yellow, Wild
        }

        public enum CardValue
        {
            Zero = 0, One, Two, Three, Four, Five, Six, Seven, Eight, Nine,
            Skip, Reverse, DrawTwo, Wild, WildDrawFour
        }
        public override string ToString()
        {
            return $"{Color} {Value}";
        }
    }
}
