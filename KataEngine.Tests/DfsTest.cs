using KataEngine.DSA;
using KataEngine.Tests.Fixtures;

namespace KataEngine.Tests
{
    public class DfsTest : ListFixtures
    {
        [Theory]
        [InlineData(0, 6, new int[] { 0, 1, 4, 5, 6 })]
        [InlineData(6, 0, null)]
        public void Test_Dfs_Graph(int source, int needle, int[]? expected)
        {
            PopulateList2();
            var result = new DFSGraphList().Dfs(List2!, source, needle);
            Assert.Equal(expected, result);
        }
    }

    public class TwoCrystallBallTest
    {
        [Fact]
        public void TwoCrystalBalls_FindsIndexOrMinusOne()
        {
            // Arrange
            int idx = new Random().Next(0, 10000);
            var data = new bool[10000];
            for (int i = idx; i < 10000; ++i)
            {
                data[i] = true;
            }

            // Act & Assert
            Assert.Equal(idx, new TwoCrystalBalls().Search(data));
            Assert.Equal(-1, new TwoCrystalBalls().Search(new bool[821]));
        }
    }
}
