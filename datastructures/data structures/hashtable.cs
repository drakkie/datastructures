
namespace datastructures
{
    public class HashTable<TKey, TValue>
    {
        private LinkedList<KeyValuePair<TKey, TValue>>[] _list;
        private int _count;
        public int Count
        {
            get => _count;
        }

        public HashTable()
        {
            _list = new LinkedList<KeyValuePair<TKey, TValue>>[1];
            _count = 0;
        }

        //hash key
        private int HashKey(TKey key, int size)
        {
            return key.GetHashCode() % size;
        }

        private void Resize()
        {
            var new_length = _list.Length * 2;
            var new_list = new LinkedList<KeyValuePair<TKey, TValue>>[new_length];

            // rehash
            foreach (var bucket in _list)
            {
                var k = bucket.Value.Key;
                var v = bucket.Value.Value;

                var new_bucket = HashKey(k, new_list.Length);

                // DRY with Add method
                var linked_list = new_list[new_bucket];
                var kvp = new KeyValuePair<TKey, TValue>(k, v);

                if (linked_list == null)
                {
                    linked_list = new LinkedList<KeyValuePair<TKey, TValue>>(kvp);
                }

                var end_node = linked_list.AppendToEnd(kvp);
                new_list[new_bucket] = end_node;

                _list = new_list;
            }
        }

        public void Add(TKey key, TValue value)
        {
            _count++;

            if (_count > _list.Length)
            {
                Resize();
            }

            var bucket = HashKey(key, _count);

            var linked_list = _list[bucket];
            var kvp = new KeyValuePair<TKey, TValue>(key, value);

            linked_list = linked_list == null ?
                 new LinkedList<KeyValuePair<TKey, TValue>>(kvp) :
                 linked_list.AppendToEnd(kvp);
                 
            _list[bucket] = linked_list;
        }
    }

    public struct KeyValuePair<TKey, TValue>
    {
        public readonly TKey Key;
        public readonly TValue Value;

        public KeyValuePair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }

    public class LinkedList<TValue>
    {
        public TValue Value;
        public LinkedList<TValue> next;
        public LinkedList<TValue> previous;

        public bool IsHead { get => previous == null; }
        public bool IsTail { get => next == null; }

        public LinkedList() { }
        public LinkedList(TValue value)
        {
            Value = value;
        }

        ///<summary>
        /// This will return the tail node
        ///</summary>
        public LinkedList<TValue> AppendToEnd(TValue value)
        {
            var node = this;

            while (!node.IsTail)
            {
                node = node.next;
            }

            node.next = new LinkedList<TValue>(value);

            return node.next;
        }
    }
}