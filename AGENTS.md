# AGENTS.md - KataEngine Development Guidelines

This document provides comprehensive guidelines for agentic coding assistants working on the KataEngine project. KataEngine is a C# .NET 10.0 project for practicing Data Structures and Algorithms (DSA) problems.

## Build System & Commands

### Build Commands
- **Full Build**: `dotnet build` - Builds the entire solution
- **Clean Build**: `dotnet clean && dotnet build` - Clean and rebuild
- **Release Build**: `dotnet build --configuration Release` - Build for production

### Test Commands
- **Run All Tests**: `dotnet test` - Execute all unit tests
- **Run Single Test**: `dotnet test --filter "FullyQualifiedName=Namespace.ClassName.MethodName"` - Run specific test
  - Example: `dotnet test --filter "BinarySearchListTest.Test_Binary_Search_List"`
- **Run Tests with Coverage**: Tests include Coverlet coverage (configured in .csproj)
- **Run Specific Test Class**: `dotnet test --filter "ClassName=BinarySearchListTest"`

### Code Generation
- **Generate DSA Stubs**: `dotnet run --project KataEngine generate` - Creates algorithm stub files
- **Clean DSA Files**: `dotnet run --project KataEngine clean` - Removes generated algorithm files

### Formatting & Linting
- **Format Code**: `dotnet format` - Apply consistent code formatting
- **Check Formatting**: `dotnet format --verify-no-changes` - Verify code is properly formatted
- **Style Fixes**: `dotnet format style` - Apply code style fixes
- **Whitespace**: `dotnet format whitespace` - Fix whitespace issues

## Project Structure

### Solution Layout
```
KataEngine/
├── KataEngine/           # Main library project (.NET 10.0)
│   ├── CodeGen/         # Code generation utilities
│   ├── Dsa/            # Generated algorithm implementations (day1/, day2/, etc.)
│   └── Program.cs      # CLI entry point
├── KataEngine.Tests/    # xUnit test project
│   └── Fixtures/       # Test data and fixtures
└── KataEngine.slnx     # Solution file
```

### Key Characteristics
- **Framework**: .NET 10.0 with implicit usings and nullable reference types enabled
- **Testing**: xUnit with Microsoft.NET.Test.Sdk and Coverlet for coverage
- **Code Generation**: Automated DSA stub generation system
- **Architecture**: Clean separation between codegen, implementation, and testing

## C# Coding Style Guidelines

### Language Features & Configuration
- **C# Version**: Latest features supported by .NET 10.0
- **Implicit Usings**: Enabled - no explicit `using` statements for common namespaces
- **Nullable Reference Types**: Enabled - use `?` for nullable references
- **File-scoped Namespaces**: Preferred for new files

### Naming Conventions

#### Classes & Types
- **PascalCase** for all type names: `BinarySearchList`, `DoublyLinkedList<T>`
- **Generic Parameters**: Single uppercase letters: `T`, `TKey`, `TValue`
- **Interfaces**: Prefix with `I`: `IEnumerable<T>`, `ICollection<T>`

#### Methods & Properties
- **PascalCase** for public methods and properties: `BsList()`, `Insert()`, `Get()`
- **Private Methods**: camelCase with underscore prefix: `_helperMethod()`
- **Test Methods**: PascalCase describing behavior: `Test_Binary_Search_List()`

#### Variables & Fields
- **camelCase** for local variables and parameters: `haystack`, `needle`, `result`
- **Private Fields**: camelCase with underscore prefix: `_head`, `_count`
- **Constants**: PascalCase: `DefaultCapacity`, `MaxSize`

### Code Structure Patterns

#### Class Organization
```csharp
namespace KataEngine.DSA;

public class ExampleClass<T>
{
    // Fields (private fields with _ prefix)
    private T? _head;
    private int _count;

    // Properties (PascalCase)
    public int Count => _count;
    public bool IsEmpty => _count == 0;

    // Constructors
    public ExampleClass() { }

    // Public methods (PascalCase)
    public void Add(T item) { /* implementation */ }
    public bool Contains(T item) { /* implementation */ }

    // Private helper methods (camelCase with _ prefix)
    private void _ensureCapacity() { /* implementation */ }
}
```

#### DSA Implementation Patterns
- **Algorithm Methods**: Clear, descriptive names matching test expectations
- **Return Types**: Use appropriate types (primitives, arrays, generics)
- **Parameter Validation**: Minimal validation unless specified by problem
- **Exception Handling**: Use `NotImplementedException` for stub methods

### Method Signatures
- **Consistent Parameter Ordering**: Input data first, then search/filter parameters
- **Array Parameters**: Use `int[]` or `T[]` for collections
- **Return Values**: `bool` for existence checks, `int`/`T` for found values, arrays for collections

### Error Handling
- **NotImplementedException**: Standard for generated stubs
- **ArgumentNullException**: For null-required parameters when nullable types enabled
- **ArgumentOutOfRangeException**: For invalid indices or bounds
- **InvalidOperationException**: For inappropriate operations on current state

### Nullability & Safety
- **Nullable References**: Use `T?` for potentially null references
- **Null Checks**: Required for parameters that cannot be null
- **Null-coalescing**: Use `??` and `?.` operators appropriately
- **Required Modifier**: Use `required` for properties that must be initialized

### Collections & Generics
- **Generic Types**: Use `<T>` for element types, `<TKey, TValue>` for maps
- **Array Usage**: Prefer arrays for fixed-size collections
- **IEnumerable<T>**: Return interface types for sequences
- **Linked Structures**: Use nullable references for `Next`/`Previous` pointers

### Testing Patterns

#### xUnit Conventions
- **Test Classes**: Named `{ClassName}Test` (e.g., `BinarySearchListTest`)
- **Test Methods**: PascalCase with descriptive names: `Test_Binary_Search_List()`
- **Theory Tests**: Use `[Theory]` with `[InlineData]` for parameterized tests
- **Assertions**: Use `Assert.True()`, `Assert.Equal()`, etc.

#### Test Data
- **Fixtures**: Use shared test data in `Fixtures/` directory
- **Edge Cases**: Test empty arrays, null values, boundary conditions
- **Expected Results**: Clear boolean/int/array results matching specifications

### Code Generation Integration
- **Stub Methods**: Implement methods marked with `NotImplementedException`
- **Method Signatures**: Match generated signatures exactly
- **Namespace**: Always `KataEngine.DSA` for algorithm implementations
- **Dependencies**: Use only standard library and project-defined types

### Import Organization
- **Implicit Usings**: Rely on project-level implicit usings
- **Explicit Imports**: Only for non-standard namespaces
- **Order**: System namespaces first, then project namespaces
- **Aliases**: Use `using` aliases sparingly, only when necessary

### Documentation & Comments
- **No Comments**: Follow the project convention of minimal/no comments
- **Self-Documenting Code**: Use clear method and variable names
- **XML Comments**: Only for public API methods if required

### Performance Considerations
- **Algorithm Complexity**: Implement efficient algorithms (O(log n), O(n), etc.)
- **Memory Usage**: Be mindful of allocations, especially in loops
- **Big O Notation**: Understand and implement appropriate complexity classes
- **Edge Cases**: Handle empty inputs, single elements, large datasets

### File Organization
- **One Class Per File**: Standard C# convention
- **File Names**: Match class names exactly
- **Directory Structure**: Follow `day{N}/` pattern for generated code
- **Test Files**: Mirror implementation structure in test project

## Tool-Specific Rules

### No Cursor Rules Found
No `.cursor/rules/` directory or `.cursorrules` file detected.

### No Copilot Rules Found
No `.github/copilot-instructions.md` file detected.

## Development Workflow

### ⚠️ IMPORTANT: Generated Code Policy
**NEVER commit generated DSA stub files to the main branch.** The `KataEngine/Dsa/` directory contains auto-generated stub files that should be created locally by each developer. These files are generated using `dotnet run --project KataEngine generate` and should be included in `.gitignore` to prevent accidental commits.

**Ensure `KataEngine/Dsa/` is added to `.gitignore` to prevent accidental commits of generated files.**

### Implementing New Algorithms
1. Run `dotnet run --project KataEngine generate` to create stubs
2. Implement methods in generated files under `KataEngine/Dsa/day{N}/`
3. Run `dotnet test --filter "ClassName={TestClassName}"` to verify
4. Run `dotnet format` to ensure code style compliance
5. **Remember: Never commit the generated `KataEngine/Dsa/` files**

### Debugging Tests
1. Use `--filter` to isolate failing tests
2. Check stack traces for `NotImplementedException` (stub methods)
3. Verify method signatures match test expectations
4. Use `dotnet test --verbosity normal` for detailed output

### Code Review Checklist
- [ ] Code builds without warnings (`dotnet build`)
- [ ] All tests pass (`dotnet test`)
- [ ] Code formatting applied (`dotnet format`)
- [ ] Naming conventions followed
- [ ] Nullability handled correctly
- [ ] Algorithm complexity appropriate
- [ ] No unused variables or imports
- [ ] Test coverage maintained
- [ ] **No generated DSA stub files committed to main branch**

## Common Issues & Solutions

### Build Failures
- **Missing DSA files**: Run `dotnet run --project KataEngine generate`
- **Test compilation errors**: Ensure DSA namespace is accessible
- **Nullable warnings**: Add `?` to nullable reference types

### Test Failures
- **NotImplementedException**: Implement the stub method
- **Signature mismatch**: Match generated method signatures exactly
- **Null reference**: Handle nullable parameters appropriately

### Formatting Issues
- **Inconsistent style**: Run `dotnet format`
- **Whitespace problems**: Use `dotnet format whitespace`
- **Style violations**: Run `dotnet format style`

This document should be updated as the project evolves. Last updated: January 2026</content>
<parameter name="filePath">C:\files\learning\dsa\cs\KataEngine\AGENTS.md