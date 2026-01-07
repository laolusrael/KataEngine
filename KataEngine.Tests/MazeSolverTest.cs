using KataEngine.CodeGen;
using KataEngine.DSA;

namespace KataEngine.Tests
{
    public class MazeSolverTest
    {
        [Fact]
        public void Test_MazeSolver()
        {
            var maze = new[]
            {
                "xxxxxxxxxx x",
                "x        x x",
                "x        x x",
                "x xxxxxxxx x",
                "x          x",
                "x xxxxxxxxxx",
            };

            var mazeResult = new Point[]
            {
                new Point { X = 10, Y = 0 },
                new Point { X = 10, Y = 1 },
                new Point { X = 10, Y = 2 },
                new Point { X = 10, Y = 3 },
                new Point { X = 10, Y = 4 },
                new Point { X = 9, Y = 4 },
                new Point { X = 8, Y = 4 },
                new Point { X = 7, Y = 4 },
                new Point { X = 6, Y = 4 },
                new Point { X = 5, Y = 4 },
                new Point { X = 4, Y = 4 },
                new Point { X = 3, Y = 4 },
                new Point { X = 2, Y = 4 },
                new Point { X = 1, Y = 4 },
                new Point { X = 1, Y = 5 }
            };

            var result = new MazeSolver().Solve(maze, "x", new Point { X = 10, Y = 0 }, new Point { X = 1, Y = 5 });
            Assert.Equal(DrawPath(maze, result), DrawPath(maze, mazeResult));
        }
        
        private static string[] DrawPath(string[] data, Point[] path)
        {
            // Create a copy of the maze as a char array
            var data2 = data.Select(row => row.ToCharArray()).ToArray();
            foreach (var p in path)
            {
                if (p.Y >= 0 && p.Y < data2.Length && p.X >= 0 && p.X < data2[p.Y].Length)
                {
                    data2[p.Y][p.X] = '*';
                }
            }
            return data2.Select(row => new string(row)).ToArray();
        }
    }
}
