using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSet.Model
{
    public class MySet<T>
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public MySet() { }

        public MySet(T data)
        {
            items.Add(data);

        }

        public EasySet(IEnumerable<T> items)
        {
            this.items = items.ToList();
        }

        public void Add(T data)
        {
            if (items.Contains(data))
            {
                return;
            }

            items.Add(data);
        }

        public void Delete(T data)
        {
            items.Remove(data);
        }

        public MySet<T> Union(MySet<T> set)
        {
            var result = new MySet<T>();

            foreach(var item in set.items)
            {
                result.Add(item);
            }

            foreach(var item in items)
            {
                result.Add(item);
            }

            return result;

        }

        public MySet<T> Intersect(MySet<T> set)
        {
            var result = new MySet<T>();

            MySet<T> greater;
            MySet<T> less;

            if(Count >= set.Count)
            {
                greater = this;
                less = set;
            }
            else
            {
                greater = set;
                less = this;
            }

            foreach(var item1 in less.items)
            {
                foreach(var item2 in greater.items)
                {
                    if(item1.Equals(item2))
                    {
                        result.Add(item1);
                        break;
                    }
                }
            }
            return result;
        }

        public MySet<T> Differ(MySet<T> set)
        {
            var result = new MySet<T>(items);

            foreach(var item in set.items)
            {
                result.Delete(item);
            }

            return result;

        }

        public bool IsSubset(MySet<T> set)
        {
            foreach(var item in set.items)
            {
                if(!items.Contains(item))
                {
                    return false;
                }
            }

            return true;
        }


    }
}
