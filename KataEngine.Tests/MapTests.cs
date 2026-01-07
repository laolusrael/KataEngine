using KataEngine.DSA;

namespace KataEngine.Tests
{
    public class MapTests
    {
        [Fact]
        public void Test_Map()
        {
            var map = new Map<string, int?>();
            
            map.Set("foo", 55);
            Assert.Equal(1, map.Size());
            
            map.Set("fool", 75);
            Assert.Equal(2, map.Size());

            map.Set("foolish", 105);
            Assert.Equal(3, map.Size());

            map.Set("bar", 69);
            Assert.Equal(4, map.Size());

            Assert.Equal(69, map.Get("bar"));
            Assert.Null(map.Get("blaz"));

            map.Delete("barblabr");
            Assert.Equal(4, map.Size());

            map.Delete("bar");
            Assert.Equal(3, map.Size());
            Assert.Null(map.Get("bar"));
        }
    }
}
