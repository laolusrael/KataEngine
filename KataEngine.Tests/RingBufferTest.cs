using KataEngine.DSA;

namespace KataEngine.Tests
{
    public class RingBufferTest
    {
        [Fact]
        public void RingBuffer_BasicPushPopBehavior()
        {
            var buffer = new RingBuffer<int?>();

            buffer.Push(5);
            Assert.Equal(5, buffer.Pop());
            Assert.Null(buffer.Pop());

            buffer.Push(42);
            buffer.Push(9);
            Assert.Equal(42, buffer.Pop());
            Assert.Equal(9, buffer.Pop());
            Assert.Null(buffer.Pop());

            buffer.Push(42);
            buffer.Push(9);
            buffer.Push(12);
            Assert.Equal(12, buffer.Get(2));
            Assert.Equal(9, buffer.Get(1));
            Assert.Equal(42, buffer.Get(0));
        }
    }
}
