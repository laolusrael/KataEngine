using KataEngine.DSA;

namespace KataEngine.Tests
{
    public class MinHeapTest
    {
        [Fact]
        public void Test_MinHeap()
        {
            int[] vals = [5, 3, 69, 420, 4, 1, 8, 7];
            var heap = new MinHeap();

            Assert.Equal(0, heap.Length);

            for (int i = 0; i < vals.Length; i++)
            {
                heap.Insert(vals[i]);
            }

            Assert.Equal(8, heap.Length);
            Assert.Equal(1, heap.Delete());
            Assert.Equal(3, heap.Delete());
            Assert.Equal(4, heap.Delete());
            Assert.Equal(5, heap.Delete());
            Assert.Equal(4, heap.Length);
            Assert.Equal(7, heap.Delete());
            Assert.Equal(8, heap.Delete());
            Assert.Equal(69, heap.Delete());
            Assert.Equal(420, heap.Delete());

            Assert.Equal(0, heap.Length);
        }
    }
}
