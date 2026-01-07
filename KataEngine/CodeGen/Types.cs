namespace KataEngine.CodeGen;

internal class Module : IModule
{
    public string Generic { get; set; } = ""; // <K,V>
    public ModuleType Type { get; set; } = ModuleType.Class;
    public IEnumerable<IMethod> Methods { get; set; } = Array.Empty<IMethod>();
    public IEnumerable<IProperty> Properties { get; set; } = Array.Empty<IProperty>();
}

internal interface IModule
{
    string Generic { get; set; }
    ModuleType Type { get; set; }
    IEnumerable<IMethod> Methods { get; set; }
    IEnumerable<IProperty> Properties { get; set; }
}

internal enum ModuleType
{
    Class,
    Interface,
    TestClass,
}

internal class Property : IProperty
{
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Scope { get; set; } = string.Empty;
}

internal interface IProperty
{
    string Name { get; set; }
    string Type { get; set; }
    string Scope { get; set; }
}

internal class Method : IMethod
{
    public string Name { get; set; } = string.Empty;
    public string Args { get; set; } = string.Empty;
    public string Return { get; set; } = "void";
}

internal interface IMethod
{
    string Name { get; set; }
    string Args { get; set; }
    string Return { get; set; }
}

public struct GraphEdge {
    public int To { get;set; }
    public int Weight { get;set; }
}

public struct Point {
    public int Y { get; set; }
    public int X { get; set; }
}

public class BinaryNode<T> {

    public T Value { get; set; }
    public BinaryNode<T>? Left { get; set; }
    public BinaryNode<T>? Right { get; set; }
}
