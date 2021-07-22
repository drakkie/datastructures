using Xunit;
using datastructures;
using System;

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
        public void Hashtable_Test()
        {
            /* arrange */
            var hashtable = new HashTable<string, string>();

            /* act */
            hashtable.Add("some key", "some val");

            /* assert */
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
    }
}
