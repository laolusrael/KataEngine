using KataEngine.DSA;

namespace KataEngine.Tests
{
    public class TrieTest
    {
        [Fact]
        public void Trie_Insert_Find_Delete_Works()
        {
            var trie = new Trie();
            trie.Insert("foo");
            trie.Insert("fool");
            trie.Insert("foolish");
            trie.Insert("bar");

            var foundFo = trie.Find("fo");
            Assert.Equal(new[] { "foo", "fool", "foolish" }, foundFo.OrderBy(x => x).ToArray());

            trie.Delete("fool");

            var foundFoAfterDelete = trie.Find("fo");
            Assert.Equal(new[] { "foo", "foolish" }, foundFoAfterDelete.OrderBy(x => x).ToArray());
        }
    }
}
