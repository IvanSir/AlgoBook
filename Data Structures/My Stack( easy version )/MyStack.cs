using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack.Model
{
    class MyStack<T>
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public void Push(T data)
        {
            items.Add(data);
        }

        public T Pop()
        {
            if (Count > 0)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else 
                throw new NullReferenceException("Stack is empty");
        }

        public T Peek()
        {
            if (Count > 0)
            {
                return items.LastOrDefault();
                
            }
            else
                throw new NullReferenceException("Stack is empty");

        }

        
    }
}
