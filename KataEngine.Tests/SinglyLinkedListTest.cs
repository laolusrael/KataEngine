using KataEngine.DSA;

namespace KataEngine.Tests
{
    public class SinglyLinkedListTest
    {
        [Fact]
        public void Test_SinglyLinkedList()
        {
            var list = new SinglyLinkedList<int?>();
            list.Append(5);
            list.Append(7);
            list.Append(9);

            Assert.Equal(9, list.Get(2));
            Assert.Equal(7, list.RemoveAt(1));
            Assert.Equal(2, list.Length);

            list.Append(11);

            Assert.Equal(9, list.RemoveAt(1));
            Assert.Null(list.Remove(9));
            Assert.Equal(5, list.RemoveAt(0));
            Assert.Equal(11, list.RemoveAt(0));
            Assert.Equal(0, list.Length);
        }
    }
}
