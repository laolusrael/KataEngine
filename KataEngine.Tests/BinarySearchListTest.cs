using KataEngine.DSA;

namespace KataEngine.Tests
{
    public class BinarySearchListTest
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 }, 69, true)]
        [InlineData(new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 }, 1337, true)]
        [InlineData(new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 }, 69420, true)]
        [InlineData(new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 }, 1, true)]
        [InlineData(new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 }, 80, false)]
        public void Test_Binary_Search_List(int[] haystack, int needle, bool expected)
        {
            var actual = new BinarySearchList().BsList(haystack, needle);
            Assert.True(actual == expected);
        }
    }
}
