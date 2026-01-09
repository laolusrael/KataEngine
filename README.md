# KataEngine

A C# .NET 10.0 project for practicing Data Structures and Algorithms (DSA) problems through automated code generation and comprehensive testing.

## Disclaimer

This project is a C# implementation inspired by [ThePrimeagen's KataMachine](https://github.com/ThePrimeagen/kata-machine), which he developed for his DSA course on Frontend Masters. KataMachine is a TypeScript/JavaScript project that provides automated code generation and testing for practicing data structures and algorithms.

## Features

- **Automated Code Generation**: Generate algorithm stub files with a single command
- **Comprehensive Test Suite**: Pre-written xUnit tests for all algorithms
- **Modern C#**: Built with .NET 10.0, implicit usings, and nullable reference types
- **Code Coverage**: Integrated Coverlet for test coverage reporting
- **Code Formatting**: Automated code formatting with `dotnet format`

## Prerequisites

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Git (for cloning the repository)

## Getting Started

### Clone the Repository

```bash
git clone <repository-url>
cd KataEngine
```

### Build the Project

```bash
# Build the entire solution
dotnet build

# Clean and rebuild
dotnet clean && dotnet build

# Build for release
dotnet build --configuration Release
```

### Generate Algorithm Stubs

Generate the initial algorithm stub files:

```bash
dotnet run --project KataEngine generate
```

This creates algorithm implementations in `KataEngine/Dsa/day{N}/` directories with method stubs that throw `NotImplementedException`.

If for some weird reason, you want to start all over:
```bash
dotnet run --project KataEngine clear
```

## Usage

### Implementing Algorithms

1. **Generate Stubs** (if not already done):
   ```bash
   dotnet run --project KataEngine generate
   ```

2. **Implement Algorithms**: Edit the generated files in `KataEngine/Dsa/day{N}/` to implement the algorithms.

3. **Run Tests**: Test your implementations:
   ```bash
   # Run all tests
   dotnet test

   # Run tests for a specific algorithm (recommended for development)
   dotnet test --filter "ClassName=BinarySearchListTest"
   dotnet test --filter "ClassName=QuickSortTest"
   ```

## Available Algorithms

The project includes stubs and tests for various DSA topics:

### Searching
- Linear Search
- Binary Search

### Sorting
- Bubble Sort
- Insertion Sort
- Quick Sort
- Merge Sort

### Data Structures
- Stack
- Queue
- Singly Linked List
- Doubly Linked List
- Ring Buffer
- Trie
- LRU Cache
- Min Heap
- Map (Hash Table)

### Graph Algorithms
- Depth-First Search (DFS)
- Dijkstra's Algorithm

### Tree Algorithms
- Binary Tree Traversals (Pre-order, In-order, Post-order)
- Binary Tree Breadth-First Search
- DFS on Binary Search Tree
- Binary Tree Comparison

### Other
- Two Crystal Balls Problem
- Maze Solver
