using KataEngine.DSA;
using KataEngine.Tests.Fixtures;

namespace KataEngine.Tests
{
    public class DjikstraListTest : ListFixtures
    {
        [Theory]
        [InlineData(0, 6, new int[] { 0, 1, 4, 5, 6 })]
        public void Test_Djikstra_Via_Adj_List(int source, int sink, int[]? expected)
        {
            PopulateList1();
            var result = new DijkstraList().Search(source, sink, List1!);
            Assert.Equal(expected, result);
        }
    }
}
