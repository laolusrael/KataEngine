using KataEngine.DSA;
using KataEngine.Tests.Fixtures;

namespace KataEngine.Tests
{
    public class BTPostOrderTest : BinaryTreeFixture
    {
        public BTPostOrderTest()
            : base()
        {

        }

        [Theory]
        [InlineData(new int[] { 5, 7, 10, 15, 20, 29, 30, 45, 50, 100 })]
        public void Test_InOrder_Bfs(int[] expected)
        {
            var result = new BTPostOrder().Order(Tree);
            Assert.Equal(result, expected);
        }
    }
}
