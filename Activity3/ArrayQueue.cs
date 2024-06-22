using System.Diagnostics.Metrics;
using System.Drawing;

namespace CSharp.Activity.Datastore
{
    /// <summary>
    /// Summary description for ArrayQueue.
    /// </summary>
    public class ArrayQueue<T> : ArrayBase<T>
    {
        // The following instance variables are accessible to all methods inside this class. You are not allowed to declare additional class members.

        // The indices of the first and last objects in the queue:
        private int first = 0;

        private int last = -1;

        // HINT: In addition to the above variables,
        // the indexer this[] (represents the queue)
        // and the Count (represents the number of objects inside the queue)
        // can be used also in this class because of inheritance.

        // HINT: Also the methods IsFull() and Contains() from ArrayBase<T>
        // can be used in this class because of inheritance.

        /// <summary>
        ///     Default constructor. Calls the base constructor.
        /// </summary>
        public ArrayQueue()
        {

        }

        /// <summary>
        ///     Constructor to initialize the data structure to the specified size.
        ///     Call the overloaded base class constructor and pass the size of the array.
        /// </summary>
        /// <param name="size">The maximum length of the array.</param>
        public ArrayQueue(int size) : base(size)
        {

        }

        /// <summary>
        ///     Method to accept an object and add to the end of the queue.
        /// </summary>
        /// <param name="next">object to enqueue</param>
        /// <returns></returns>
        public virtual bool Enqueue(T next)
        {
            #region Activity 3.0
            //TODO Activity 3.0
            //This method adds the object 'next' to the end of the queue assuming that the queue is not full
            //and that a similar object is not already it he queue.  Return true if the queue is successful, and
            //false otherwise.
            //If 'next' is a null object, throw an ArgumentNullException with a descriptive message.


            if (IsFull() || IndexOf(next) != -1)
            {
                return false;
            }
            if (next == null)
            {
                throw new ArgumentNullException(nameof(next), "Cannot enqueue a null object.");
            }
            last = (last + 1) % Capacity;
            base[last] = next;
            Count++;
            return true;
            #endregion
        }
    


        /// <summary>
        ///     Method to remove the object from the queue.
        /// </summary>
        /// <returns></returns>
        public virtual T Dequeue()
        {
            #region Activity 3.1
            //TODO Activity 3.1
            //This removes the next object from the start of queue and returns it. If there is nothing to return
            //then throw InvalidOperationException() exception.

            if (IsEmpty())
            {
                throw new InvalidOperationException("Circular queue is empty.");
            }
            T item = base[first];
            first = (first + 1) % Capacity;
            Count--;
            return item;
            //// Returns the dequeued element
            //RemoveAt(first);
            //return temp;

            // in the final solution this statement should be deleted or modified
            #endregion
        }

        /// <summary>
        ///     Method to check an object at the beginning of the queue.
        /// </summary>
        /// <returns></returns>
        public T CheckNext()
            => base[first];

        /// <summary>
        ///     Method to check whether there is any other object in the queue.
        /// </summary>
        /// <returns></returns>
        public bool HasNext()
            => (base.Count != 0);

        /// <summary>
        ///     Method to accept an object and find whether the object exists in the array structure.
        /// </summary>
        /// <param name="arg">object</param>
        /// <returns></returns>
        public override int IndexOf(T arg)
        {
            #region Activity 3.2
            //TODO Activity 3.2
            //Compares 'arg' using the Equals() method and returns its place relative to the start of the queue.
            //If there is no object in the queue that qualifies, then return NOT_IN_STRUCTURE.
            //Trying to find a null object should throw an ArgumentNullException.
               if (arg == null)
                   throw new ArgumentNullException(nameof(arg), "Cannot search for a null object.");

                for (int i = 0; i < Count; i++)
                {
                    int index = (first + i) % Capacity;
                if (base[index].Equals(arg))
                {
                    return i;
                }
                }

                return NOT_IN_STRUCTURE; // If not found, return -1

            //start solution
            #endregion
        }

        /// <summary>
        ///     Method to accept the index of for and array object and return the corresponding object.
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>the object for the specified index</returns>
        public T Check(int index)
        {
            #region Activity 3.3
            //TODO Activity 3.3
            //Find which object is currently at the specified index relative to the start of the queue.
            //The start of the queue is index 0

            //start solution

            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            // Calculate the actual index based on the first index and return the element
            int actualIndex = (first + index) % base.Count;
            return base[actualIndex]; // in the final solution this statement should be deleted or modified
            #endregion
        }
    }
}