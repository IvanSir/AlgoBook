using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDeque.Model
{
    public class MyDeque<T>
    {
        public List<T> items = new List<T>();
        public T Head => items.Last();

        public T Tail => items.First();

        public MyDeque(T data)
        {
            items.Add(data);

        }

        public void PushBack(T data)
        {
            items.Insert(0, data);
        }

        public void PushFront(T data)
        {
            items.Add(data);
        }

        public T PopBack()
        {
            var item = Tail;
            items.Remove(item);
            return item;

        }

        public T PopFront()
        {
            var item = Head;
            items.Remove(item);
            return item;

        }

        public T PeekBack() => Tail;

        public T PeekFront() => Head;
    }
}
