namespace datastructures
{
    public class HashTable<TKey, TValue>
    {
        private ArrayList<LinkedList<TValue>> _list;

        //hash key
        public void Add(TKey key, TValue value)
        {
            var hash = key.GetHashCode();
            var bucket = hash % _list.Size;

            
        }
    }

    // TODO: extract out to own file
    public class LinkedList<TValue>
    {
        public TValue Value;
        public LinkedList<TValue> next;
        public LinkedList<TValue> previous;

        private bool _isHead;
        public bool IsHead
        {
            get { return _isHead; }
            private set { _isHead = previous == null; }
        }

        private bool _isTail;
        public bool IsTail
        {
            get { return _isTail; }
            private set { _isHead = next == null; }
        }
    }
}