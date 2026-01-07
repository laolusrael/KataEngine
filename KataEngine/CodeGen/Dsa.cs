namespace KataEngine.CodeGen;
internal static class Dsa
{
    static List<IMethod> _ListInterface =
    [
        new Method
        {
            Name = "Prepend",
            Args = "T item",
            Return = "void"
        },
        new Method {
            Name = "InsertAt",
            Args = "T item, int idx",
            Return = "void"
        },
        new Method {
            Name = "Append",
            Args = "T item",
            Return = "void"
        },
        new Method {
            Name = "Remove",
            Args = "T item",
            Return = "T?"
        },
        new Method {
            Name = "Get",
            Args = "int idx",
            Return = "T?"
        },
        new Method {
            Name = "RemoveAt",
            Args = "int idx",
            Return = "T?"
        }
    ];

    static List<IProperty> _LengthProperty = [
        new Property {
            Name = "Length",
            Type = "int",
            Scope = "private"
        }
    ];

    public static Dictionary<string, IModule> Modules => new Dictionary<string, IModule>
    {
        {
            "LRU" ,
            new Module
            {
                Generic = "<K, V>",
                Methods =
                [
                    new Method
                    {
                        Name = "Update",
                        Args = "K key, V value",
                        Return = "void"
                    },
                    new Method {
                        Name = "Get",
                        Args = "K key",
                        Return = "V?"
                    }
                ],
                Properties = [
                    new Property {
                        Name = "Length",
                        Type = "int",
                        Scope = "private"
                    }
                ]
            }
        },
        {
            "MinHeap" ,
            new Module
            {
                Methods =
                [
                    new Method
                    {
                        Name = "Insert",
                        Args = "int value",
                        Return = "void"
                    },
                    new Method {
                        Name = "Delete",
                        Args = "",
                        Return = "int"
                    }
                ],
                Properties = [
                    new Property {
                        Name = "Length",
                        Type = "int",
                        Scope = "public"
                    }
                ]
            }
        },
        {
            "Map" ,
            new Module
            {
                Generic = "<T, V>",
                Methods =
                [
                    new Method
                    {
                        Name = "Get",
                        Args = "T key",
                        Return = "V"
                    },
                    new Method {
                        Name = "Set",
                        Args = "T key, V value",
                        Return = "void"
                    },
                    new Method {
                        Name = "Delete",
                        Args = "T key",
                        Return = "V?"
                    },
                    new Method {
                        Name = "Size",
                        Return = "int"
                    }
                ],
            }
        },
        {
            "RingBuffer" ,
            new Module
            {
                Generic = "<T>",
                Methods =
                [
                    new Method
                    {
                        Name = "Push",
                        Args = "T item",
                        Return = "void"
                    },
                    new Method {
                        Name = "Get",
                        Args = "int idx",
                        Return = "T?"
                    },
                    new Method {
                        Name = "Pop",
                        Return = "T?"
                    }
                ],
                Properties = [
                    new Property {
                        Name = "Length",
                        Type = "int",
                        Scope = "public"
                    }
                ]
            }
        },
        {
            "ArrayList" ,
            new Module
            {
                Generic = "<T>",
                Methods =  [.. _ListInterface],
                Properties = [.. _LengthProperty]
            }
        },
        {
            "SinglyLinkedList" ,
            new Module
            {
                Generic = "<T>",
                Methods =  [.. _ListInterface],
                Properties = [.. _LengthProperty]
            }
        },
        {
            "DoublyLinkedList" ,
            new Module
            {
                Generic = "<T>",
                Methods =  [.. _ListInterface],
                Properties = [.. _LengthProperty]
            }
        },
        {
            "Queue" ,
            new Module
            {
                Generic = "<T>",
                Properties =  [.. _LengthProperty],
                Methods = [
                    new Method {
                        Name = "Enqueue",
                        Args = "T item",
                        Return =  "void"
                    },
                    new Method {
                        Name = "Dequeue",
                        Args = "",
                        Return  = "T?"
                    },
                    new Method {
                        Name = "Peek",
                        Args = "",
                        Return = "T?"
                    }
                ]
            }
        },
        {
            "Stack" ,
            new Module
            {
                Generic = "<T>",
                Properties =  [.. _LengthProperty],
                Methods = [
                    new Method {
                        Name = "Push",
                        Args = "T item",
                        Return =  "void"
                    },
                    new Method {
                        Name = "Pop",
                        Args = "",
                        Return  = "T?"
                    },
                    new Method {
                        Name = "Peek",
                        Args = "",
                        Return = "T?"
                    }
                ]
            }
        },
        {
            "TwoCrystalBalls",
            new Module
            {
                Methods = [
                    new Method {
                        Name = "Search",
                        Args = "bool[] breaks",
                        Return = "int"
                    }]
            }
        },
        {
            "Trie" ,
            new Module
            {
                Methods = [
                    new Method {
                        Name = "Insert",
                        Args = "string item",
                        Return =  "void"
                    },
                    new Method {
                        Name = "Delete",
                        Args = "string item",
                        Return  = "void"
                    },
                    new Method {
                        Name = "Find",
                        Args = "string partial",
                        Return = "string[]"
                    }
                ]
            }
        },
        {
            "LinearSearchList" ,
            new Module
            {
                Methods =
                [
                    new Method
                    {
                        Name = "LinearSearch",
                        Args = "int[] haystack, int needle",
                        Return = "bool"
                    }
                ]
            }
        },
        {
            "BinarySearchList",
            new Module
            {
                Methods =
                [
                    new Method
                    {
                        Name = "BsList",
                        Args = "int[] haystack, int needle",
                        Return = "bool"
                    }
                ]
            }
        },
        {
            "BubbleSort",
            new Module
            {
                Methods =
                [
                    new Method
                    {
                        Name = "Sort",
                        Args = "int[] arr",
                        Return = "void"
                    }
                ]
            }
        },
        {
            "InsertionSort",
            new Module
            {
                Methods =
                [
                    new Method
                    {
                        Name = "Sort",
                        Args = "int[] arr",
                        Return = "void"
                    }
                ]
            }
        },
        {
            "MergeSort",
            new Module
            {
                Methods =
                [
                    new Method
                    {
                        Name = "Sort",
                        Args = "int[] arr",
                        Return = "void"
                    }
                ]
            }
        },
        {
            "QuickSort",
            new Module
            {
                Methods =
                [
                    new Method
                    {
                        Name = "Sort",
                        Args = "int[] arr",
                        Return = "void"
                    }
                ]
            }
        },
        {
            "DijkstraList",
            new Module
            {
                Methods =
                [
                    new Method
                    {
                        Name = "Search",
                        Args = "int source, int sink, GraphEdge[][] arr",
                        Return = "int[]"
                    }
                ]
            }
        },
        {
            "PrismsList",
            new Module {
                Methods = [
                    new Method {
                        Name = "Prisms",
                        Args = "GraphEdge[][] list",
                        Return = "GraphEdge[][]"
                    }
                ]
            }
        },
        {
            "TowCrystalBalls",
            new Module {
                Methods = [
                    new Method {
                        Name = "Find",
                        Args = "bool[] breaks",
                        Return = "int"
                    }
                ]
            }
        },
        {
            "MazeSolver",
            new Module {
                Methods = [
                    new Method {
                        Name = "Solve",
                        Args = "string[] maze, string wall, Point start, Point end",
                        Return = "Point[]"
                    }
                ]
            }
        },
        {
            "BTPreOrder",
            new Module {
                Methods = [
                    new Method {
                        Name = "Order",
                        Args = "BinaryNode<int> head",
                        Return = "int[]"
                    }
                ]
            }
        },
        {
            "BTInOrder",
            new Module {
                Methods = [
                    new Method {
                        Name = "Order",
                        Args = "BinaryNode<int> head",
                        Return = "int[]"
                    }
                ]
            }
        },
        {
            "BTPostOrder",
            new Module {
                Methods = [
                    new Method {
                        Name = "Order",
                        Args = "BinaryNode<int> head",
                        Return = "int[]"
                    }
                ]
            }
        },
        {
            "BTBFS",
            new Module {
                Methods = [
                    new Method {
                        Name = "Bfs",
                        Args = "BinaryNode<int> head, int needle",
                        Return = "bool"
                    }
                ]
            }
        },
        {
            "CompareBinaryTrees",
            new Module {
                Methods = [
                    new Method {
                        Name = "Compare",
                        Args = "BinaryNode<int>? a, BinaryNode<int>? b",
                        Return = "bool"
                    }
                ]
            }
        },
        {
            "DFSOnBST",
            new Module {
                Methods = [
                    new Method {
                        Name = "Dfs",
                        Args = "BinaryNode<int> head, int needle",
                        Return = "bool"
                    }
                ]
            }
        },
        {
            "DFSGraphList",
            new Module {
                Methods = [
                    new Method {
                        Name = "Dfs",
                        Args = "GraphEdge[][] graph, int source, int needle",
                        Return = "int[]?"
                    }
                ]
            }
        },
        {
            "BFSGraphMatrix",
            new Module {
                Methods = [
                    new Method {
                        Name = "Bfs",
                        Args = "GraphEdge[][] graph, int source, int needle",
                        Return = "int[]?"
                    }
                ]
            }
        },

    };
}
