using KataEngine.DSA;

namespace KataEngine.Tests
{
    public class MergeSortTest
    {
        [Theory]
        [InlineData(new int[] { 9, 3, 7, 4, 69, 420, 42 }, new int[] { 3, 4, 7, 9, 42, 69, 420 })]
        public void Sort_DataIsSorted(int[] test, int[] control)
        {
            new MergeSort().Sort(test);
            Assert.Equal(test, control);
        }
    }
}
