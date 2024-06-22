using CSharp.Activity.Polymorphysm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Polymorphism
{
    // Rectangle class that inherits from Shape and implements IPrintable interface
    public class Rectangle : Shape, IPrintable
    {
        // Public properties to store the length and width of the rectangle
        public double Length { get; protected set; }
        public double Width { get; protected set; }

        // Constructor to initialize the Rectangle with given length and width
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Override method to calculate and print the area of the rectangle
        public override void CalculateArea()
        {
            double area = Length * Width;
            Console.WriteLine("Area: " + area);
        }

        // Implementation of the IPrintable interface's Print method
        public void Print()
        {
            Console.WriteLine($"Length: {Length}, Width: {Width}");
        }
    }
}
