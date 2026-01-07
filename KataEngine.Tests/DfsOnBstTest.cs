using KataEngine.DSA;
using KataEngine.Tests.Fixtures;

namespace KataEngine.Tests
{
    public class DfsOnBstTest : BinaryTreeFixture
    {
        [Theory]
        [InlineData( 45, true)]
        [InlineData( 7, true)]
        [InlineData( 69, false)]
        public void Test_Dfs_On_BST(int needle, bool expected)
        {
            PopulateTree();
            var result = new DFSOnBST().Dfs(Tree!, needle);
            Assert.Equal(expected, result);
        }
    }
}
