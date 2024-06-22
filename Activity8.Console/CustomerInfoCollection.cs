using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Collections
{
    // Collection class to manage a list of CustomerInfo objects
    public class CustomerInfoCollection
    {
        private List<CustomerInfo> customers;

        // Constructor to initialize the collection
        public CustomerInfoCollection()
        {
            customers = new List<CustomerInfo>();
        }

        // Indexer for accessing CustomerInfo objects by index
        public CustomerInfo this[int index]
        {
            get
            {
                if (index < 0 || index >= customers.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                return customers[index];
            }
            set
            {
                if (index < 0 || index >= customers.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                customers[index] = value;
            }
        }

        // Add a CustomerInfo object to the collection and return its index
        public int Add(CustomerInfo customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null.");
            }
            else if (customers.Contains(customer))
            {
                return -1; // Customer already exists in the collection
            }
            else
            {
                customers.Add(customer);
                return customers.IndexOf(customer);
            }
        }

        // Insert a CustomerInfo object at the specified index
        public void Insert(int index, CustomerInfo customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null.");
            }
            else if (index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                customers.Insert(index, customer);
            }
        }

        // Check if the collection contains a specific CustomerInfo object
        public bool Contains(CustomerInfo customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null.");
            }
            else
            {
                return customers.Contains(customer);
            }
        }

        // Remove a CustomerInfo object from the collection
        public void Remove(CustomerInfo customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null.");
            }
            else
            {
                customers.Remove(customer);
            }
        }

        // Get the index of a CustomerInfo object in the collection
        public int IndexOf(CustomerInfo customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null.");
            }
            else if (!customers.Contains(customer))
            {
                return -1; // Customer not found in the collection
            }
            else
            {
                return customers.IndexOf(customer);
            }
        }
    }
}
