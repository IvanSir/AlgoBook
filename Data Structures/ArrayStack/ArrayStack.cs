using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack.Model
{
    public class ArrayStack<T>
    {
        T[] items;

        public int Count => current + 1;

        public int current = -1;

        public ArrayStack(int size = 10)
        {
            items = new T[size];
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[0] = data;
            current = 0;
            
        }

        public void Push(T data)
        {
            if (current < items.Length - 1)
            {
                current++;
                items[current] = data;
                
            }
            else
                throw new StackOverflowException();
        }

        public T Pop()
        {
            if (current >= 0)
            {
                var item = items[current];
                items[current] = default;

                current--;

                return item;

            }
            else
                throw new NullReferenceException();
        }

        public T Peek()
        {
            if (current >= 0)
            { 
                return items[current];

            }
            else
                throw new NullReferenceException();

        }

    }
}
