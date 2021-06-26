using System.Collections.Generic;

namespace datastructures
{
    public class StringBuilder
    {
        private readonly List<string> _words;
        private int _size;

        public StringBuilder() 
        {
            _words = new List<string>();
        }

        public void Append(string word) 
        {
            _words.Add(word);
            _size += word.Length;
        }

        public override string ToString()
        {
            var str = new char[_size];

            var i = 0;
            foreach (var word in _words)
            {
                foreach (var ch in word) 
                {
                    str[i++] = ch;
                }
            }

            return new string(str);
        }
    }
}
