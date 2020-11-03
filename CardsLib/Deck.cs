using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace CardLib
{
    /// <summary>
    /// Represents a deck of cards.
    /// </summary>
    public class Deck : ICollection<Card>, IEnumerable<Card>, ICollection, IEnumerable
    {
        /// <summary>
        /// The deck
        /// </summary>
        protected Stack<Card> deck;

        /// <summary>
        /// Initializes a new instance of the CardLib.Deck class.
        /// </summary>
        public Deck()
        {
            deck = new Stack<Card>();
        }

        /// <summary>
        /// Initializes a new instance of the CardLib.Deck class from a list of cards.
        /// </summary>
        /// <param name="cards">The cards.</param>
        public Deck(IEnumerable<Card> cards)
        {
            deck = new Stack<Card>();
            foreach (Card card in cards.Reverse<Card>())
                deck.Push(new Card(card));
        }

        /// <summary>
        /// Shuffles this instance.
        /// </summary>
        public Deck Shuffle()
        {
            Random rnd = new Random();
            Card[] cards = deck.ToArray();
            for (int i = 0; i < cards.Length; i++)
            {
                int random = rnd.Next(i, cards.Length);
                Card temp = cards[random];
                cards[random] = cards[i];
                cards[i] = temp;
            }
            deck = new Stack<Card>(cards);
            return this;
        }

        /// <summary>
        /// Remove a card from the top of the deck.
        /// </summary>
        /// <returns>The top card.</returns>
        public Card TakeTopCard()
        {
            return deck.Pop();
        }

        /// <summary>
        /// Peek at the top card of the deck.
        /// </summary>
        /// <returns>The top card of the deck.</returns>
        public Card PeekAtTopCard()
        {
            return deck.Peek();
        }

        /// <summary>
        /// Put a card on top of the deck.
        /// </summary>
        /// <param name="card">The card to put on the top.</param>
        public void PutCardOnTop(Card card)
        {
            deck.Push(card);
        }

        /// <summary>
        /// Insert a card to the bottom of the deck.
        /// </summary>
        /// <param name="card">The card to insert.</param>
        public void InsertCardFromBottom(Card card)
        {
            Stack<Card> temp = new Stack<Card>();
            while (deck.Count > 0)
                temp.Push(deck.Pop());
            deck.Push(card);
            while (temp.Count > 0)
                deck.Push(temp.Pop());
        }

        /// <summary>
        /// Adds the specified card.
        /// </summary>
        /// <param name="card">The card.</param>
        void ICollection<Card>.Add(Card card)
        {
            deck.Push(card);
        }

        /// <summary>
        /// Removes all cards from the deck.
        /// </summary>
        public void Clear()
        {
            deck.Clear();
        }

        /// <summary>
        /// Determines whether the deck has the specific card.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <returns>
        ///   true if the deck containes the card, otherwise false.
        /// </returns>
        public bool Contains(Card card)
        {
            return deck.Contains(card);
        }

        /// <summary>
        /// Copies to an array from a specific index.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="arrayIndex">Index of the array.</param>
        public void CopyTo(Card[] array, int arrayIndex)
        {
            deck.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Gets the number of cards contained in the deck.
        /// </summary>
        public int Count { get { return deck.Count; } }

        /// <summary>
        /// Gets a value indicating whether the deck is read-only.
        /// </summary>
        public bool IsReadOnly { get { return false; } }

        /// <summary>
        /// Removes a specified card.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <returns></returns>
        bool ICollection<Card>.Remove(Card card)
        {
            if (!deck.Contains(card))
                return false;
            Stack<Card> temp = new Stack<Card>();
            Card tempCard = deck.Pop();
            while (tempCard != card)
            {
                temp.Push(tempCard);
                tempCard = deck.Pop();
            }
            while (temp.Count > 0)
                deck.Push(temp.Pop());
            return true;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// An enumerator that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<Card> GetEnumerator()
        {
            return deck.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An enumerator that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)deck).GetEnumerator();
        }

        /// <summary>
        /// Copies to.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
        void ICollection.CopyTo(Array array, int index)
        {
            ((ICollection)deck).CopyTo(array, index);
        }

        /// <summary>
        /// Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).
        /// </summary>
        bool ICollection.IsSynchronized { get { return ((ICollection)deck).IsSynchronized; } }

        /// <summary>
        /// Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.
        /// </summary>
        object ICollection.SyncRoot { get { return ((ICollection)deck).SyncRoot; } }

        /// <summary>
        /// Gets an array of unshuffled cards.
        /// </summary>
        /// <returns>An unshuffled array of cards.</returns>
        public static Card[] getUnshuffledCards()
        {
            Card[] unshaffled = new Card[52];
            for (int i = 0; i < 13; i++)
            {
                unshaffled[i] = new Card(CardSuit.Spades, i + 2);
                unshaffled[i + 13] = new Card(CardSuit.Hearts, i + 2);
                unshaffled[i + 26] = new Card(CardSuit.Diamonds, i + 2);
                unshaffled[i + 39] = new Card(CardSuit.Clubs, i + 2);
            }
            return unshaffled;
        }

        /// <summary>
        /// Gets an unshuffled deck.
        /// </summary>
        /// <returns>An unshuffled deck.</returns>
        public static Deck getUnshuffledDeck()
        {
            Stack<Card> cards = new Stack<Card>(getUnshuffledCards().Reverse());
            return new Deck(cards);
        }
    }
}
