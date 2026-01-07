using KataEngine.CodeGen;

namespace KataEngine.Tests.Fixtures
{
    public class ListFixtures : IClassFixture<GraphEdge[][]>
    {
        protected GraphEdge[][]? List1 { get; set; }
        protected GraphEdge[][]? List2 { get; set; }
        protected int[][]? Matrix2 { get; set; }


        public void PopulateList1()
        {
            if (List1 == null)
            {
                List1 = new GraphEdge[6][];
            }

            List1[0] =
            [
                new GraphEdge { To = 1, Weight = 3 },
                new GraphEdge { To = 2, Weight= 1}
            ];

            List1[1] =
            [
                new GraphEdge { To = 0, Weight = 3 },
                new GraphEdge { To = 2, Weight = 4},
                new GraphEdge { To = 4, Weight = 1},
            ];

            List1[2] =
            [
                new GraphEdge { To = 1, Weight = 4 },
                new GraphEdge { To = 3, Weight= 7},
                new GraphEdge { To = 0, Weight = 1}
            ];

            List1[3] =
            [
                new GraphEdge { To = 2, Weight = 7},
                new GraphEdge { To = 4, Weight = 5},
                new GraphEdge { To = 6, Weight = 1}
            ];

            List1[4] =
            [
                new GraphEdge { To = 1, Weight = 1 },
                new GraphEdge { To = 3, Weight= 5},
                new GraphEdge { To = 5, Weight = 2}
            ];

            List1[5] =
            [
                new GraphEdge { To = 6, Weight = 1 },
                new GraphEdge { To = 4, Weight= 2},
                new GraphEdge { To = 2, Weight = 18}
            ];

            List1[6] =
            [
                new GraphEdge { To = 3, Weight = 1 },
                new GraphEdge { To = 5, Weight= 1}
            ];
        }

        public void PopulateList2()
        {
            if (List2 == null)
            {
                List2 = new GraphEdge[6][];
            }

            List2[0] = [
                new GraphEdge{ To = 1, Weight = 3},
                new GraphEdge{ To = 2, Weight = 1},
            ];

            List2[1] = [new GraphEdge { To = 4, Weight = 1 }];
            List2[2] = [new GraphEdge { To = 3, Weight = 7 }];
            List2[3] = [];
            List2[4] = [
                new GraphEdge{ To = 1, Weight = 3},
                new GraphEdge{ To = 3, Weight = 5},
                new GraphEdge{ To = 5, Weight = 2},
            ];

            List2[5] = [
                new GraphEdge{ To = 2, Weight = 18},
                new GraphEdge{ To = 6, Weight = 1},
            ];
            List2[6] = [new GraphEdge { To = 3, Weight = 1 }];
        }

        public void PopulateMatrix() => Matrix2 ??=
        [
            [0, 3, 1, 0, 0, 0, 0],
            [0, 0, 0, 0, 1, 0, 0], 
            [0, 0, 7, 0, 0, 0, 0], 
            [0, 0, 0, 0, 0, 0, 0], 
            [0, 1, 0, 5, 0, 2, 0], 
            [0, 0, 18, 0, 0, 0, 1],
            [0, 0, 0, 1, 0, 0, 1]
        ];
    }
}
