using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NewQueue.Model
{
    public class MyQueue<T>
    {
        public List<T> items = new List<T>();

        public T Head => items.First();

        public T Last => items.Last();

        public MyQueue(T data)
        {
            items.Insert(0,data);
        }

        public void Add(T data)
        {
            items.Add(data);
        }

        public T Pop()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }

        public T Peek() => Head;
    }
}
