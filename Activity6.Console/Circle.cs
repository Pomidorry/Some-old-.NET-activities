using CSharp.Activity.Polymorphysm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Polymorphism
{
    // Circle class that inherits from Shape and implements IPrintable interface
    public class Circle : Shape, IPrintable
    {
        // Public property to store the radius of the circle
        public double Radius { get; protected set; }

        // Constructor to initialize the Circle with a given radius
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Override method to calculate and print the area of the circle
        public override void CalculateArea()
        {
            Console.WriteLine($"Area: " + Math.PI * Math.Pow(Radius, 2));
        }

        // Implementation of the IPrintable interface's Print method
        public void Print()
        {
            Console.WriteLine($"Radius: {Radius}");
        }
    }
}

