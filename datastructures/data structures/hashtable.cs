namespace datastructures.data_structures
{
    public class HashTable<TKey, TValue>
    {

        //hash key
        public void Add(TKey key, TValue value)
        {
            var hash = key.GetHashCode();
        }
    }
}