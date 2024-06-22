// See https://aka.ms/new-console-template for more information
using CSharp.Activity.Collections;
using CSharp.Activity.CoreUtilities;

// Display the list of environment variables and values

FileHandling fileHandling = new FileHandling("MY_FILE_PATH");
CustomerInfoCollection customers = new CustomerInfoCollection();

fileHandling.WriteToDisk(customers.Add(new CustomerInfo ( 1, "John","john@example.com")).ToString());
fileHandling.WriteToDisk(customers.Add(new CustomerInfo(2, "Ann", "Ann@example.com")).ToString());