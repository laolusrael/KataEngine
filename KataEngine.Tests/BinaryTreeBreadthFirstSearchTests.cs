using KataEngine.DSA;
using KataEngine.Tests.Fixtures;

namespace KataEngine.Tests
{
    public class BinaryTreeBreadthFirstSearchTests : BinaryTreeFixture
    {
        public BinaryTreeBreadthFirstSearchTests()
            : base()
        {
            
        }

        [Theory]
        [InlineData (45, true)]
        [InlineData(7, true)]
        [InlineData(69, false)]
        public void Test_Bfs_On_Bt(int needle, bool expected)
        {
            var result =  new BTBFS().Bfs(Tree, needle);
            Assert.Equal(result, expected);
        }
    }
}
