using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack.Model
{
    class LinkedStack<T>
    {
        public Item<T> Head { get; set; }

        public int Count { get; set; }

        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }

        public LinkedStack(T data)
        {
            Head = new Item<T>(data);
            Count = 1;
        }


        public void Add(T data)
        {
            var item = new Item<T>(data)
            {
                Previous = Head
            };
            
            Head = item;

            Count++;
        }

        public T Pop()
        {
            if (Count > 0)
            {
                var item = Head;
                Head = Head.Previous;
                Count--;
                return item.Data;

            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public T Peek()
        {
            if (Count > 0)
            {
             
                return  Head.Data;

            }
            else
            {
                throw new NullReferenceException();
            }

        }
    }
}
