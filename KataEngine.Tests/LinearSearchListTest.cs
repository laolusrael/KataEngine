using KataEngine.DSA;
using System.Runtime.InteropServices;

namespace KataEngine.Tests
{
    public class LinearSearchListTest
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 }, 69, true)]
        [InlineData(new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 }, 1337, true)]
        [InlineData(new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 }, 69420, true)]
        [InlineData(new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 }, 1, true)]
        [InlineData(new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 }, 80, false)]
        public void Test_Linear_Search_List(int[] haystack, int needle, bool expected)
        {
            var actual = new LinearSearchList().LinearSearch(haystack, needle);
            Assert.True(actual == expected);
        }
    }
}
