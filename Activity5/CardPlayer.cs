using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.CardGame
{
    public class CardPlayer : PlayerProfile
    {
        private ICard[] hand;

        // Maximum number of cards this player can hold in their hand.
        public int MaxSize { get; set; }

        // Current number of cards in the player's hand.
        public int CardCount { get; set; }

        // Constructor to initialize the CardPlayer.
        public CardPlayer(string name, char gender, DateTime birthDate, int numberOfCards) : base(name, gender, birthDate)
        {
            MaxSize = numberOfCards;
            CardCount = 0;
            hand = new SimpleCard[numberOfCards];
        }

        // Check if the player's hand is full.
        public bool IsFull()
        {
            return CardCount == MaxSize;
        }

        // Get a card from the player's hand at the specified index.
        public ICard GetCard(int index)
        {
            return hand[index];
        }

        // Add a card to the player's hand.
        public bool AddCard(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentNullException();
            }
            else if (IsFull())
            {
                return false; // Hand is already full.
            }

            CardCount++;
            hand[CardCount - 1] = card;
            return true;
        }

        // Remove a card from the player's hand.
        public bool RemoveCard(ICard card)
        {
            int index = -1;
            if (card == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < CardCount; i++)
            {
                if (card.Equals(hand[i]))
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                return false; // Card not found in hand.
            }

            for (int i = index; i < CardCount - 1; i++)
            {
                hand[i] = hand[i + 1];
            }
            CardCount--;
            return true;
            
        }
    }
}
