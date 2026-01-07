using KataEngine.DSA;
using KataEngine.Tests.Fixtures;

namespace KataEngine.Tests
{
    public class CompareBinaryTreeTest : BinaryTreeFixture
    {
        public CompareBinaryTreeTest()
            : base()
        {

        }

        [Theory]
        [InlineData(true)]
        public void Test_InOrder_Bfs(bool expected)
        {
            var result = new CompareBinaryTrees().Compare(Tree, Tree);

            Assert.Equal(result, expected);
            Assert.Equal(Tree, Tree2);
        }
    }
}
