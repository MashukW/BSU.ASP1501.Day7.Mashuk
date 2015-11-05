using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    public class CustomQueue<T>
    {
        private T[] items;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public T this[int index]
        {
            get
            {
                if (index >= count && index < 0)
                    throw new IndexOutOfRangeException("Incorrect index");
                return items[index];
            }
        }

        #region Сlass constructors
        public CustomQueue() : this(0)
        {
        }

        public CustomQueue(int length)
        {
            if (length < 0)
                throw new ArgumentException("length");
            items = new T[length];
            count = 0;
        }

        public CustomQueue(IEnumerable<T> elements)
        {
            if (elements == null)
                throw new ArgumentNullException("A sequence of elements is null");

            int index = 0;
            items = new T[elements.Count()];
            foreach (T element in elements)
                items[index++] = element;
            count = elements.Count();
        }
        #endregion

        #region Public methods (Enqueue, Dequeue, Peek)
        public void Enqueue(T item)
        {
            if (count == items.Length)
                ToExpandArray();
            items[count++] = item;
        }

        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException("The queue is empty");

            T temp = items[0];
            Array.Copy(items, 1, items, 0, items.Length - 1);
            count--;
            return temp;
        }

        public T Peek()
        {
            if (count == 0)
                throw new InvalidOperationException("The queue is empty");

            return items[0];
        }
        #endregion

        private void ToExpandArray()
        {
            int newSize = items.Length == 0 ? 5 : items.Length << 1;
            T[] temp = new T[newSize];
            items.CopyTo(temp, 0);
            items = temp;
        }

        public CustomerEnumerator<T> GetEnumerator()
        {
            return new CustomerEnumerator<T>(this);
        }
    }
}
