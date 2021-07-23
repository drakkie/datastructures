namespace datastructures
{
    public class ArrayList<T>
    {
        private T[] _array;
        private int _added;

        // indexer
        public T this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        public int Size {
            get { return _added; }
        }

        public ArrayList()
        {
            _array = new T[1];
            _added = 0;
        }

        public void Add(T thing)
        {
            _array[_added] = thing;
            _added++;

            if (_added >= _array.Length)
            {
                DoubleUp();
            }
            
        }

        private void DoubleUp()
        {
            var len = _array.Length * 2;
            var newArray = new T[len];

            var i = 0;
            foreach (var item in _array)
            {
                newArray[i++] = item;
            }

            _array = newArray;
        }
    

    }
}