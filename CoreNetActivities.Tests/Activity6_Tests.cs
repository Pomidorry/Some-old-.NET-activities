using CSharp.Activity.Datastore;
using CSharp.Activity.Polymorphysm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity6.Tests
{
    [TestClass]
    public class Activity6_Tests
    {
        [TestMethod]
        //[Ignore]
        public void TestRectangle()
        {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter); // Redirect Console.WriteLine to StringWriter

            // Act
            // Call the method or code that writes to the console
            // For example, if your console output method is called "PrintToConsole()"
            Rectangle rectangle = new Rectangle(10, 20);
            rectangle.CalculateArea();

            // Assert
            string expectedOutput = "Area: " + 200;
            string actualOutput = stringWriter.ToString().Trim(); // Get the console output as a string

            // Assert the expected output matches the actual output
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void TestCircle()
        {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter); // Redirect Console.WriteLine to StringWriter

            // Act
            // Call the method or code that writes to the console
            // For example, if your console output method is called "PrintToConsole()"
            Circle circle = new Circle(5);
            circle.CalculateArea();

            // Assert
            string expectedOutput = "Area: " + 78.53981633974483;
            string actualOutput = stringWriter.ToString().Trim(); // Get the console output as a string

            // Assert the expected output matches the actual output
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
