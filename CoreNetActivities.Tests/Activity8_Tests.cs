using CSharp.Activity.Collections;
using CSharp.Activity.CoreUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity8.Tests
{
    [TestClass]
    public class CustomerInfoCollectionTests
    {
        private CustomerInfoCollection customerCollection;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the customer collection before each test method
            customerCollection = new CustomerInfoCollection();
        }

        [TestMethod]
        public void Add_NewCustomer_ShouldReturnCorrectIndex()
        {
            // Arrange
            CustomerInfo customer1 = new CustomerInfo(1, "John", "john@example.com");
            CustomerInfo customer2 = new CustomerInfo(2, "Jane", "jane@example.com");

            // Act
            int index1 = customerCollection.Add(customer1);
            int index2 = customerCollection.Add(customer2);

            // Assert
            Assert.AreEqual(0, index1, "Index of customer1 should be 0");
            Assert.AreEqual(1, index2, "Index of customer2 should be 1");
        }

        [TestMethod]
        public void Add_DuplicateCustomer_ShouldReturnNegativeIndex()
        {
            // Arrange
            CustomerInfo customer1 = new CustomerInfo(1, "John", "john@example.com");

            // Act
            int index1 = customerCollection.Add(customer1);
            int index2 = customerCollection.Add(customer1);

            // Assert
            Assert.AreEqual(0, index1, "Index of customer1 should be 0");
            Assert.AreEqual(-1, index2, "Index of customer2 should be -1 (duplicate customer)");
        }

        [TestMethod]
        public void Insert_ValidIndex_ShouldInsertCustomer()
        {
            // Arrange
            CustomerInfo customer1 = new CustomerInfo(1, "John", "john@example.com");
            CustomerInfo customer2 = new CustomerInfo(2, "Jane", "jane@example.com");

            customerCollection.Add(customer1);

            // Act
            customerCollection.Insert(0, customer2);

            // Assert
            Assert.AreEqual(1, customerCollection.IndexOf(customer1));
            Assert.AreEqual(customer2, customerCollection[0], "Inserted customer should be at index 0");
        }

    }
    [TestClass]
    public class FileHandlingTests
    {
        private const string TestFilePath = "testfile.txt"; // Replace with a valid file path for testing

        [TestInitialize]
        public void TestInitialize()
        {
            // Create or clear the test file before each test method
            File.WriteAllText(TestFilePath, string.Empty);
        }

        [TestMethod]
        public void ReadFromFile_ValidFile_ShouldReturnContent()
        {
            // Arrange
            string expectedContent = "Test file content.";
            File.WriteAllText(TestFilePath, expectedContent);

            FileHandling fileHandler = new FileHandling(TestFilePath);

            // Act
            string actualContent = fileHandler.ReadFromDisk();

            // Assert
            Assert.AreEqual(expectedContent, actualContent, "File content should be read correctly.");
        }

        [TestMethod]
        public void WriteToFile_ValidContent_ShouldWriteToFile()
        {
            // Arrange
            string contentToWrite = "Test file content.";
            FileHandling fileHandler = new FileHandling(TestFilePath);

            // Act
            fileHandler.WriteToDisk(contentToWrite);

            // Assert
            string actualContent = File.ReadAllText(TestFilePath);
            Assert.AreEqual(contentToWrite, actualContent, "File content should be written correctly.");
        }

        [TestMethod]
        public void WriteToFile_EmptyContent_ShouldCreateEmptyFile()
        {
            // Arrange
            string contentToWrite = "";
            FileHandling fileHandler = new FileHandling(TestFilePath);

            // Act
            fileHandler.WriteToDisk(contentToWrite);

            // Assert
            string actualContent = File.ReadAllText(TestFilePath);
            Assert.AreEqual(contentToWrite, actualContent, "File content should be written correctly.");
        }

    }
}
