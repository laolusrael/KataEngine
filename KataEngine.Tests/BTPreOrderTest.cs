using KataEngine.DSA;
using KataEngine.Tests.Fixtures;

namespace KataEngine.Tests
{
    public class BTPreOrderTest : BinaryTreeFixture
    {
        public BTPreOrderTest()
            : base()
        {

        }

        [Theory]
        [InlineData(new int[] { 20, 10, 5, 7, 15, 50, 30, 29, 45, 100 })]
        public void Test_InOrder_Bfs(int[] expected)
        {
            var result = new BTPreOrder().Order(Tree);
            Assert.Equal(result, expected);
        }
    }
}
