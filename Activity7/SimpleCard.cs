using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.CardGame1
{
    public class SimpleCard : ICard
    {
        public int CardAttribute { get; set; }
        //return card attribute
        public string GetCardAttribute()
        {
            return "Card "+CardAttribute.ToString();
        }
    }
}
