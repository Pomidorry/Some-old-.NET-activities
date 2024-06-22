using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.CoreUtilities
{
    public class FileHandling
    {
        private string filePath;

        // Constructor to initialize the FileHandling class with a file path
        public FileHandling(string FilePath)
        {
            filePath = FilePath;
        }

        // Read content from the specified file on disk
        public string ReadFromDisk()
        {
            try
            {
                // Open the file stream for reading
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // Use a stream reader to read the content from the file
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        // Read the entire content of the file and return it
                        return streamReader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs during file reading, rethrow with a generic exception
                throw new Exception("Error reading from disk: " + ex.Message);
            }
        }

        // Write content to the specified file on disk
        public void WriteToDisk(string content)
        {
            try
            {
                // Open the file stream for writing (create or overwrite)
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    // Use a stream writer to write the content to the file
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        streamWriter.Write(content);
                    }
                }
                Console.WriteLine("File write successful.");
            }
            catch (Exception ex)
            {
                // If an exception occurs during file writing, throw an exception with the specific error message
                throw new Exception("Error writing to disk: " + ex.Message);
            }
        }
    }
}
