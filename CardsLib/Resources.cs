using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CardLib;

namespace CardLib
{
    internal static class Resources
    {
        internal static Dictionary<KeyPair<CardVal, CardSuit>, Bitmap> cardPics;

        internal static void InitializeDictionary()
        {
            cardPics = new Dictionary<KeyPair<CardVal, CardSuit>, Bitmap>();
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Two, CardSuit.Spades), Properties.Resources._2_of_spades);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Three, CardSuit.Spades), Properties.Resources._3_of_spades);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Four, CardSuit.Spades), Properties.Resources._4_of_spades);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Five, CardSuit.Spades), Properties.Resources._5_of_spades);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Six, CardSuit.Spades), Properties.Resources._6_of_spades);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Seven, CardSuit.Spades), Properties.Resources._7_of_spades);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Eight, CardSuit.Spades), Properties.Resources._8_of_spades);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Nine, CardSuit.Spades), Properties.Resources._9_of_spades);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Ten, CardSuit.Spades), Properties.Resources._10_of_spades);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Jack, CardSuit.Spades), Properties.Resources.jack_of_spades);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Queen, CardSuit.Spades), Properties.Resources.queen_of_spades);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.King, CardSuit.Spades), Properties.Resources.king_of_spades);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Ace, CardSuit.Spades), Properties.Resources.ace_of_spades);

            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Two, CardSuit.Hearts), Properties.Resources._2_of_hearts);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Three, CardSuit.Hearts), Properties.Resources._3_of_hearts);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Four, CardSuit.Hearts), Properties.Resources._4_of_hearts);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Five, CardSuit.Hearts), Properties.Resources._5_of_hearts);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Six, CardSuit.Hearts), Properties.Resources._6_of_hearts);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Seven, CardSuit.Hearts), Properties.Resources._7_of_hearts);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Eight, CardSuit.Hearts), Properties.Resources._8_of_hearts);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Nine, CardSuit.Hearts), Properties.Resources._9_of_hearts);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Ten, CardSuit.Hearts), Properties.Resources._10_of_hearts);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Jack, CardSuit.Hearts), Properties.Resources.jack_of_hearts);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Queen, CardSuit.Hearts), Properties.Resources.queen_of_hearts);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.King, CardSuit.Hearts), Properties.Resources.king_of_hearts);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Ace, CardSuit.Hearts), Properties.Resources.ace_of_hearts);

            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Two, CardSuit.Diamonds), Properties.Resources._2_of_diamonds);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Three, CardSuit.Diamonds), Properties.Resources._3_of_diamonds);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Four, CardSuit.Diamonds), Properties.Resources._4_of_diamonds);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Five, CardSuit.Diamonds), Properties.Resources._5_of_diamonds);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Six, CardSuit.Diamonds), Properties.Resources._6_of_diamonds);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Seven, CardSuit.Diamonds), Properties.Resources._7_of_diamonds);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Eight, CardSuit.Diamonds), Properties.Resources._8_of_diamonds);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Nine, CardSuit.Diamonds), Properties.Resources._9_of_diamonds);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Ten, CardSuit.Diamonds), Properties.Resources._10_of_diamonds);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Jack, CardSuit.Diamonds), Properties.Resources.jack_of_diamonds);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Queen, CardSuit.Diamonds), Properties.Resources.queen_of_diamonds);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.King, CardSuit.Diamonds), Properties.Resources.king_of_diamonds);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Ace, CardSuit.Diamonds), Properties.Resources.ace_of_diamonds);

            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Two, CardSuit.Clubs), Properties.Resources._2_of_clubs);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Three, CardSuit.Clubs), Properties.Resources._3_of_clubs);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Four, CardSuit.Clubs), Properties.Resources._4_of_clubs);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Five, CardSuit.Clubs), Properties.Resources._5_of_clubs);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Six, CardSuit.Clubs), Properties.Resources._6_of_clubs);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Seven, CardSuit.Clubs), Properties.Resources._7_of_clubs);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Eight, CardSuit.Clubs), Properties.Resources._8_of_clubs);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Nine, CardSuit.Clubs), Properties.Resources._9_of_clubs);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Ten, CardSuit.Clubs), Properties.Resources._10_of_clubs);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Jack, CardSuit.Clubs), Properties.Resources.jack_of_clubs);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Queen, CardSuit.Clubs), Properties.Resources.queen_of_clubs);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.King, CardSuit.Clubs), Properties.Resources.king_of_clubs);
            cardPics.Add(new KeyPair<CardVal, CardSuit>(CardVal.Ace, CardSuit.Clubs), Properties.Resources.ace_of_clubs);
        }
    }

    internal struct KeyPair<Tkey1, Tkey2>
    {
        Tkey1 Key1 { get; set; }
        Tkey2 Key2 { get; set; }

        public KeyPair(Tkey1 key1, Tkey2 key2) : this()
        {
            Key1 = key1;
            Key2 = key2;
        }
    }
}
