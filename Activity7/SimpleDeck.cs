using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.CardGame1
{

    public class SimpleDeck : CardDeck
    {
        public SimpleCard[] Cards;
        //copy data to Cards
        public override void InitializeDeck()
        {
            Cards = new SimpleCard[ArrayCards.Length];
            for (int i = 0; i < ArrayCards.Length; i++)
            {
                PutCard(new SimpleCard());
                Cards[i] = (SimpleCard)ArrayCards[i];
            }
        }
    }

}
