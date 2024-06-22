using System;
using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace CSharp.Activity.Datastore
{
    public class ArrayStore<T> : AbstractArrayStore<T>
    {
        public ArrayStore(int size) : base(size)
        {

        }

        // Add an item to the array store.
        public override int Add(T argToAdd)
        {
            if (argToAdd == null)
            {
                throw new ArgumentNullException();
            }
            else if (IsFull() || IndexOf(argToAdd) != NOT_IN_STRUCTURE)
            {
                return NOT_IN_STRUCTURE; // Item already exists or the store is full.
            }
            else
            {
                Count++;
                base[Count - 1] = argToAdd; // Add item to the end of the array.
                return Count - 1;
            }
        }

        // Remove an item at a specific index from the array store.
        public override void RemoveAt(int removeObjectIndex)
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Impossible to remove.");
            }
            else if (removeObjectIndex < 0 || removeObjectIndex >= Count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
            else
            {
                // Shift the remaining array items to the left to compact the array.
                for (int i = removeObjectIndex; i < Count - 1; i++)
                {
                    base[i] = base[i + 1];
                }

                // Decrease the Count to reflect the removal of an item.
                Count--;
            }
        }

        // Remove the first occurrence of a specific item from the array store.
        public override void Remove(T argToRemove)
        {
            if (argToRemove == null)
            {
                throw new ArgumentNullException();
            }
            else if (IndexOf(argToRemove) == -1)
            {
                throw new InvalidOperationException("Item not found.");
            }
            else
            {
                for (int i = IndexOf(argToRemove); i < Count - 1; i++)
                {
                    base[i] = base[i + 1];
                }
                Count--;
            }
        }

        // Insert an item at a specific index in the array store.
        public override int Insert(T argToInsert, int indexToInsert)
        {
            if (argToInsert == null)
            {
                throw new ArgumentNullException();
            }
            else if (IsFull() || IndexOf(argToInsert) != NOT_IN_STRUCTURE)
            {
                return NOT_IN_STRUCTURE; // Item already exists or the store is full.
            }
            else if (indexToInsert < 0 || indexToInsert >= Capacity)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = Count - 1; i >= indexToInsert; i--)
                {
                    base[i + 1] = base[i]; // Shift items to the right to make space.
                }

                // Insert the new item at the specified index.
                base[indexToInsert] = argToInsert;

                // Increase the count to reflect the new number of elements in the array.
                Count++;
                return indexToInsert;
            }
        }
    }
}