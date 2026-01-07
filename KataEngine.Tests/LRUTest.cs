using KataEngine.DSA;

namespace KataEngine.Tests
{
    public class LRUTest
    {
        [Fact]
        public void Test_LRU()
        {
            var lru = new LRU<string, int?>();

            Assert.Null(lru.Get("foo"));
            lru.Update("foo", 69);
            Assert.Equal(69, lru.Get("foo"));

            lru.Update("bar", 420);
            Assert.Equal(420, lru.Get("bar"));

            lru.Update("baz", 1337);
            Assert.Equal(1337, lru.Get("baz"));

            lru.Update("ball", 69420);
            Assert.Equal(69420, lru.Get("ball"));
            Assert.Null(lru.Get("foo")); 
            Assert.Equal(420, lru.Get("bar"));

            lru.Update("foo", 69);
            Assert.Equal(420, lru.Get("bar"));
            Assert.Equal(69, lru.Get("foo"));

            Assert.Null(lru.Get("baz"));
        }
    }
}
