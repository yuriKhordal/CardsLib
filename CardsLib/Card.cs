using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CardLib
{
    /// <summary>
    /// Represents a playing card
    /// </summary>
    public class Card
    {
        /// <summary>
        /// The suit of the card
        /// </summary>
        public CardSuit Suit { get; set; }
        /// <summary>
        /// The number of the card
        /// </summary>
        public CardVal Val { get; set; }

        /// <summary>
        /// Initializes a new instance of the CardLib.Card class with a given card suit and card number
        /// </summary>
        /// <param name="suit">The suit of the new card</param>
        /// <param name="val">The number of the new card</param>
        public Card(CardSuit suit, CardVal val)
        {
            Suit = suit;
            Val = val;
            
        }

        /// <summary>
        /// Initializes a new instance of the CardLib.Card class with a given card suit and card number
        /// </summary>
        /// <param name="suit">The suit of the new card</param>
        /// <param name="val">The number of the new card</param>
        public Card(CardSuit suit, int val)
        {
            Suit = suit;
            Val = (CardVal)val;
        }

        /// <summary>
        /// Initializes a new instance of the CardLib.Card class with a given card suit and card number
        /// </summary>
        /// <param name="suit">The suit of the new card</param>
        /// <param name="val">The number of the new card</param>
        public Card(char suit, CardVal val)
        {
            Suit = (CardSuit)suit;
            Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the CardLib.Card class with a given card suit and card number
        /// </summary>
        /// <param name="suit">The suit of the new card</param>
        /// <param name="val">The number of the new card</param>
        public Card(char suit, int val)
        {
            Suit = (CardSuit)suit;
            Val = (CardVal)val;
        }

        /// <summary>
        /// Initializes a new instance of the CardLib.Card class with a number and suit from another card
        /// </summary>
        /// <param name="card">The card from which to copy the number and suit</param>
        public Card(Card card)
        {
            Suit = card.Suit;
            Val = card.Val;
        }

        /// <summary>
        /// Gets the short name of the card in the syntax: A♠
        /// </summary>
        /// <returns>returns the short name of the card in the syntax: A♠</returns>
        public string ShortName()
        {
            char suit = (char)Suit;
            string val = (int)Val + "";
            switch (val)
            {
                case "11": val = "J"; break;
                case "12": val = "Q"; break;
                case "13": val = "K"; break;
                case "14": val = "A"; break;
            }
            return val + suit;
        }

        /// <summary>
        /// Represents the card in a string of the format: "Ace of Spades"
        /// </summary>
        /// <returns>returns a string that represents the card in the format of "Ace of Spades"</returns>
        public override string ToString()
        {
            return this.Val + " of " + this.Suit;
        }


        /// <summary>
        /// Get a Bitmap class of the picture of the card. If the card is null, returnes the back of the card.
        /// </summary>
        /// <param name="card">The card</param>
        /// <returns>Bitmap of the picture of the card.</returns>
        public static Bitmap GetCardPicture(Card card)
        {
            if (Resources.cardPics == null)
                Resources.InitializeDictionary();
            if (card == null)
                return Properties.Resources.Back;
            return Resources.cardPics[new KeyPair<CardVal, CardSuit>(card.Val, card.Suit)];
        }

        /// <summary>
        /// Get a Bitmap class of the picture of the card. If the card is null, returnes the back of the card.
        /// </summary>
        /// <param name="val">Number/Value of the card</param>
        /// <param name="suit">Suit of the card</param>
        /// <returns>Bitmap of the picture of the card.</returns>
        public static Bitmap GetCardPicture(CardVal val, CardSuit suit)
        {
            if (Resources.cardPics == null)
                Resources.InitializeDictionary();
            return Resources.cardPics[new KeyPair<CardVal, CardSuit>(val, suit)];
        }
    }

    /// <summary>
    /// A suit of a playing card
    /// </summary>
    public enum CardSuit
    {
        Spades = '♠',
        Hearts = '♥',
        Diamonds = '♦',
        Clubs = '♣'
    }

    /// <summary>
    /// A number of a playing card
    /// </summary>
    public enum CardVal
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
