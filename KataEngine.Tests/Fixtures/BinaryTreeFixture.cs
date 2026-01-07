using KataEngine.CodeGen;

namespace KataEngine.Tests.Fixtures
{
    public class BinaryTreeFixture: IClassFixture<BinaryNode<int>>
    {
        protected BinaryNode<int>? Tree {  get; set; }
        protected BinaryNode<int>? Tree2 { get; set; }
        public BinaryTreeFixture()
        {
            PopulateTree();
            PopulateTree2();
        }

        public void PopulateTree()
        {
            if (Tree == null)
            {
                Tree = new BinaryNode<int>();
            }

            Tree.Value = 20;
            Tree.Right = new BinaryNode<int>()
            {
                Value = 50,
                Right = new BinaryNode<int>
                {
                    Value = 100,
                },
                Left = new BinaryNode<int>()
                {
                    Value = 30,
                    Right = new BinaryNode<int> { Value = 45 },
                    Left = new BinaryNode<int> { Value = 29 }
                }
            };
            Tree.Left = new BinaryNode<int>
            {
                Value = 10,
                Right = new BinaryNode<int> { Value = 15 },
                Left = new BinaryNode<int>
                {
                    Value = 5,
                    Right = new BinaryNode<int> { Value = 7 }
                }
            };
        }
        public void PopulateTree2 ()
        {
            if (Tree == null)
            {
                Tree = new BinaryNode<int>();
            }

            Tree.Value = 20;
            Tree.Right = new BinaryNode<int>()
            {
                Value = 50,
                Left = new BinaryNode<int>
                {
                    Value = 30,
                    Right = new BinaryNode<int> { 
                        Value = 45,
                        Right = new BinaryNode<int> { Value = 49 }
                    },
                    Left = new BinaryNode<int> { 
                        Value = 29,
                        Left = new BinaryNode<int> { Value = 21 }
                    }
                }
            };
            Tree.Left = new BinaryNode<int>
            {
                Value = 10,
                Right = new BinaryNode<int> { Value = 15 },
                Left = new BinaryNode<int>
                {
                    Value = 5,
                    Right = new BinaryNode<int> { Value = 7 }
                }
            };
        }
    }
}
