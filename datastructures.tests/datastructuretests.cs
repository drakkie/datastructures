using Xunit;
using datastructures;
using System;
using System.Linq;

namespace datastructures.tests
{
    public class DataStructure_Tests
    {
        [Theory]
        [InlineData("some chars")]
        public void StringBuilder_Tests(string str)
        {
            /* arrange */
            var sb = new StringBuilder();
            
            /* act */
            sb.Append(str);

            /* assert */
            Assert.True(str == sb.ToString());

        }

        [Fact]
        public void Hashtable_CanAddMultiple()
        {
            /* arrange */
            var hashtable = new HashTable<string, string>();

            /* act */
            foreach (var i in Enumerable.Range(0, 100))
            {
                hashtable.Add($"key{i}", $"value{i}");
            }

            /* assert */
            Assert.True(hashtable.Count == 1);
        }

        [Fact]
        public void ArrayList_IndexerWorks()
        {
            /* arrange */
            var list = new ArrayList<string>();
            list.Add("one");
            list.Add("two");
            list.Add("three");

            /* act */
            var value = list[1];

            /* assert */
            Assert.True(value == "two");
            
        }

        [Fact]
        public void ArrayList_SizeWorks()
        {
            /* arrange */
            var list = new ArrayList<string>();
            list.Add("one");
            list.Add("two");

            /* act */
            var size = list.Size;

            /* assert */
            Assert.True(size == 2);

        }
    }
}
