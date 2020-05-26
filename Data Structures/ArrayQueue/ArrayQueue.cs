using System.Linq;


namespace NewQueue.Model
{
    public class ArrayQueue<T>
    {
        private T[] items;

        public int Count { get; private set; }

        public T Head => items[Count > 0 ? Count - 1 : 0];

        public T Tail => items[0];

        public ArrayQueue(int size, T data)
        {
            items = new T[size];
            items[0] = data;
            Count = 1;
        }

        public ArrayQueue(int size)
        {
            items = new T[size];
            Count = 0;
        }

        public void Add(T data)
        {
            if (Count < items.Length)
            {
                var result = (new T[] { data }).Concat(items);
                items = result.ToArray();
                Count++;
            }
        }

        public T Pop()
        {
            var item = Head;
            Count--;
            return item;
        }

        public T Peek()
        {
            return Head;
        }
    }
}
