
namespace NewHashTable
{
    public class MyHashTable<T>
    {
        private Item<T>[] items;

        public MyHashTable(int size)
        {
            items = new Item<T>[size];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<T>(i);
            }

        }

        public void Add(T data)
        {
            var key = GetHash(data);


            items[key].Nodes.Add(data);
        }

        private int GetHash(T data) => data.GetHashCode() % items.Length; 
        

        public bool Find(T data)
        {
            var key = GetHash(data);

            return items[key].Nodes.Contains(data);

        }
    }
}
