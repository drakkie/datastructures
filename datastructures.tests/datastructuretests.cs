using Xunit;
using datastructures;

namespace datastructures.tests
{
    public class DataStructureTests
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
    }
}
