namespace KataEngine.Tests
{
    public class QueueTest
    {
        [Fact]
        public void Test_Queue()
        {
            var list = new DSA.Queue<int>();

            list.Enqueue(5);
            list.Enqueue(7);
            list.Enqueue(9);

            Assert.Equal(5, list.Dequeue());
            Assert.Equal(2, list.Length);

            list.Enqueue(11);
            Assert.Equal(7, list.Dequeue());
            Assert.Equal(9, list.Dequeue());
            Assert.Equal(11, list.Peek());
            Assert.Equal(11, list.Dequeue());
            Assert.Throws<InvalidOperationException>(() => list.Dequeue());
            Assert.Equal(0, list.Length);

            list.Enqueue(69);
            Assert.Equal(69, list.Peek());
            Assert.Equal(1, list.Length);
        }
    }
}
