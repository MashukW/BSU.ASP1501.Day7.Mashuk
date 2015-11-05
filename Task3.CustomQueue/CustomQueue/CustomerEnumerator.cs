using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    public struct CustomerEnumerator<T>
    {
        private readonly CustomQueue<T> customQueue;
        private int position;

        public CustomerEnumerator(CustomQueue<T> collection)
        {
            this.customQueue = collection;
            position = -1;
        }

        public T Current
        {
            get 
            {
                if (position == customQueue.Count - 1)
                    Reset();
                if (position == -1)
                    MoveNext();

                return customQueue[position];
            }
        }

        public bool MoveNext()
        {
            return ++position < customQueue.Count;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose() { }
    }
}