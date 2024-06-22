using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Polymorphysm
{
    abstract public class Shape
    {
        public double Area { get; protected set; }
        public abstract void CalculateArea();
    }
}
