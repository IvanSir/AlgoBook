using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList.Model
{
    public class DubLinkedList<T> :IEnumerable
    {
        public DubItem<T> Head { get; set; }
        public DubItem<T> Tail { get; set; }

        public int Count { get; set; }

        public DubLinkedList(T data)
        {
            Head = Tail = new DubItem<T>(data);

            Count = 1;
        }

        public void Add(T data)
        {
            var item = new DubItem<T>(data);

            Tail.Next = item;
            item.Prev =  Tail;

            Tail = item;

            Count++;

        }

        public void Delete(T data)
        {
            var current = Head;
            while(current != null)
            {
                if(current.Data.Equals(data))
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
                    Count--;

                    return;

                }
                current = current.Next;
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
           while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
