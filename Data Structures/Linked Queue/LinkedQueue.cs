using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewQueue.Model
{
    public class LinkedQueue<T>
    {
        private Item<T> head;
        
        private Item<T> tail;

        public int Count { get; private set; }

        public LinkedQueue(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            head = tail = new Item<T>(data);

            Count = 1;
        }

        public void Add(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);

            }
            else
            {
                var item = new Item<T>(data)
                { 
                    Next = tail
                };

                tail = item;

                Count++;

            }
        }

        public T Pop()
        {
            var data = head.Data;

            var current = tail.Next;
            var previous = tail;
           
            while (current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }

            head = previous;
            head.Next = null;
            Count--;
            return data;
        }

        public T Peek()
        {
            return head.Data;
        }
    }
}
