using KataEngine.DSA;

namespace KataEngine.Tests
{
    public class QuickSortTest
    {
        [Fact]
        public void QuickSort_SortsArrayCorrectly()
        {
            int[] arr = { 9, 3, 7, 4, 69, 420, 42 };
            new QuickSort().Sort(arr);
            Assert.Equal(new int[] { 3, 4, 7, 9, 42, 69, 420 }, arr);
        }
    }
}
