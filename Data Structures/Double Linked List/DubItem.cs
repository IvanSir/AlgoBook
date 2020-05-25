using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList.Model
{
    public class DubItem<T>
    {
        public T Data { get; set; }

        public DubItem<T> Prev { get; set; }
        public DubItem<T> Next { get; set; }

        public DubItem(T data)
        {
            Data = data;

        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
