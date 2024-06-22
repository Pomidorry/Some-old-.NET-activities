using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharp.Activity.CardGame1
{
    // Abstract base class for a card deck
    public abstract class CardDeck
    {
        public int CardCount { get; private set; }
        private const int defaultNumber = 10;
        public ICard[] ArrayCards;

        // Abstract method to initialize the deck (to be implemented in derived classes)
        public abstract void InitializeDeck();

        // Default constructor
        public CardDeck()
        {
            CardCount = 0;
            ArrayCards = new ICard[defaultNumber];
            InitializeDeck();
        }

        // Constructor with a specified number of cards
        public CardDeck(int number)
        {
            CardCount = 0;
            ArrayCards = new ICard[number];
            InitializeDeck();
        }

        // Put a card into the deck
        public bool PutCard(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentNullException(nameof(card), "Cannot enqueue a null object.");
            }
            else if (CardCount == ArrayCards.Length)
            {
                return false; // Deck is full
            }
            else
            {
                CardCount++;
                ArrayCards[CardCount - 1] = card;
                return true;
            }
        }

        // Find the index of a card in the deck
        public int IndexOf(ICard card)
        {
            // Loop through the array
            for (int i = 0; i < CardCount; i++)
            {
                // Check if the argument at the current index is equal to the input argument
                if (ArrayCards[i].Equals(card))
                {
                    return i;
                }
            }

            // Input argument is not found.
            return -1;
        }

        // Get a specific card from the deck and remove it
        public ICard GetCard(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentNullException(nameof(card), "Cannot dequeue a null object.");
            }
            else if (IndexOf(card) == -1)
            {
                throw new ArgumentException(); // Card not found in the deck
            }
            else
            {
                for (int i = IndexOf(card); i < CardCount - 1; i++)
                {
                    ArrayCards[i] = ArrayCards[i + 1];
                }
                CardCount--;
                return card;
            }
        }

        // Get a random card from the deck and remove it
        public ICard GetCard()
        {
            if (CardCount == 0)
            {
                return null; // No cards in the deck
            }
            Random random = new Random();
            int index = random.Next(CardCount);
            ICard card = ArrayCards[index];

            // Shift the remaining array items to the left to compact the array.
            if (index != CardCount - 1)
            {
                for (int i = index; i < CardCount - 1; i++)
                {
                    ArrayCards[i] = ArrayCards[i + 1];
                }
            }
            // Decrease the Count to reflect the removal of an item.
            CardCount--;

            return card;
        }
    }
}
