using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CardLib
{
    /// <summary>
    /// Represents a hand of cards.
    /// </summary>
    public class Hand : IList<Card>, ICollection<Card>, IEnumerable<Card>, IList, ICollection, IEnumerable
    {
        /// <summary>
        /// The cards.
        /// </summary>
        protected List<Card> cards;

        /// <summary>
        /// Initializes a new instance of the CardLib.Hand class that is empty of cards.
        /// </summary>
        public Hand()
        {
            cards = new List<Card>();
        }

        /// <summary>
        /// Initializes a new instance of the CardLib.Hand class with cards from another list.
        /// </summary>
        /// <param name="cards">The cards.</param>
        public Hand(IEnumerable<Card> cards)
        {
            foreach (Card card in cards)
                this.cards.Add(new Card(card));
        }

        /// <summary>
        /// Gets or sets the card at the specified index.
        /// </summary>
        /// <value>The card</value>
        /// <param name="index">The zero-based index of the card to get or set.</param>
        /// <returns>The card at the specified index.</returns>
        public Card this[int index] { get { return cards[index]; } set { cards[index] = value; } }

        /// <summary>
        /// Searches for the card and returns the index of it.
        /// </summary>
        /// <param name="card">The card to search.</param>
        /// <returns>The first index of the card in the hand, if not found -1.</returns>
        public int IndexOf(Card card)
        {
            return cards.IndexOf(card);
        }

        /// <summary>
        /// Inserts the card in the given index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="card">The card.</param>
        public void Insert(int index, Card card)
        {
            cards.Insert(index, card);
        }

        /// <summary>
        /// Removes card from the cpecific index.
        /// </summary>
        /// <param name="index">The index.</param>
        public void RemoveAt(int index)
        {
            cards.RemoveAt(index);
        }

        /// <summary>
        /// Adds the specified card.
        /// </summary>
        /// <param name="item">The card.</param>
        public void Add(Card card)
        {
            cards.Add(card);
        }

        /// <summary>
        /// Removes all cards from the hand.
        /// </summary>
        public void Clear()
        {
            cards.Clear();
        }

        /// <summary>
        /// Determines whether the given card is in the hand.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <returns>true if the card is in the hand, otherwise false.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Contains(Card card)
        {
            return cards.Contains(card);
        }

        /// <summary>
        /// Copies to card array from a specific index.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="arrayIndex">Index of the array.</param>
        public void CopyTo(Card[] array, int arrayIndex)
        {
            cards.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Gets the number of cards in the hand.
        /// </summary>
        public int Count { get { return cards.Count; } }

        /// <summary>
        /// Gets a value indicating whether the hand is read-only.
        /// </summary>
        bool ICollection<Card>.IsReadOnly { get { return false; } }

        /// <summary>
        /// Removes the specified card.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <returns></returns>
        public bool Remove(Card card)
        {
            return cards.Remove(card);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// An enumerator that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<Card> GetEnumerator()
        {
            return cards.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An enumerator that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)cards).GetEnumerator();
        }

        /// <summary>
        /// Adds the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        int IList.Add(object value)
        {
            return ((IList)cards).Add(value);
        }

        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified value]; otherwise, <c>false</c>.
        /// </returns>
        bool IList.Contains(object value)
        {
            return ((IList)cards).Contains(value);
        }

        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        int IList.IndexOf(object value)
        {
            return ((IList)cards).IndexOf(value);
        }

        /// <summary>
        /// Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="value">The value.</param>
        void IList.Insert(int index, object value)
        {
            ((IList)cards).Insert(index, value);
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="T:System.Collections.IList" /> has a fixed size.
        /// </summary>
        bool IList.IsFixedSize
        {
            get { return false; }
        }

        bool IList.IsReadOnly { get { return false; } }

        /// <summary>
        /// Removes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        void IList.Remove(object value)
        {
            ((IList)cards).Remove(value);
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Object"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.Object"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        object IList.this[int index] { get { return ((IList)cards)[index]; } set { ((IList)cards)[index] = value; } }

        /// <summary>
        /// Copies to.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
        void ICollection.CopyTo(Array array, int index)
        {
            ((ICollection)cards).CopyTo(array, index);
        }

        /// <summary>
        /// Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).
        /// </summary>
        bool ICollection.IsSynchronized { get { return ((ICollection)cards).IsSynchronized; } }

        /// <summary>
        /// Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.
        /// </summary>
        object ICollection.SyncRoot { get { return ((ICollection)cards).SyncRoot; } }
    }
}
