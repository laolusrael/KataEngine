namespace KataEngine.Tests
{
    public class StackTest
    {
        [Fact]
        public void Stack_Behavior_Test()
        {
            var list = new DSA.Stack<int>();

            list.Push(5);
            list.Push(7);
            list.Push(9);

            Assert.Equal(9, list.Pop());
            Assert.Equal(2, list.Length);

            list.Push(11);
            Assert.Equal(11, list.Pop());
            Assert.Equal(7, list.Pop());
            Assert.Equal(5, list.Peek());
            Assert.Equal(5, list.Pop());
            Assert.Throws<InvalidOperationException>(() => list.Pop());

            list.Push(69);
            Assert.Equal(69, list.Peek());
            Assert.Equal(1, list.Length);
        }
    }
}
