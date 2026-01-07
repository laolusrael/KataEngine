using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace KataEngine.CodeGen
{
    internal class Generator
    {
        private string GenerateMethod(IMethod method) => $"public {method.Return} {method.Name}({method.Args}){{\r\t\tthrow new NotImplementedException(); \r\t}}";
        private string GenerateProperty(IProperty property) => $"public {property.Type} {property.Name} {{ get; set; }}";
        private void CreateClass(string name, IModule item, string dayPath) {
            File.WriteAllTextAsync(
                Path.Combine(dayPath, $"{name}.cs"),
@$"using KataEngine.CodeGen;

namespace KataEngine.DSA;
public class {name}{item.Generic ?? string.Empty}
{{{string.Join("\n    ", (item.Properties ?? []).Select(GenerateProperty)).Trim()}
    {string.Join("\n    ", (item.Methods ?? []).Select(GenerateMethod)).Trim()}
}}");
        }

        public void Generate(string srcPath)
        {
            if (string.IsNullOrEmpty(srcPath))
            {
                srcPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..\\Dsa");
            }

            int day = 1;

            try
            {
                day = Convert.ToInt32(Directory.GetDirectories(srcPath)
                    .Where(i => i.StartsWith("day"))
                    .Order()
                    .FirstOrDefault()?.Substring(3) ?? "0") + 1;
            }
            catch (Exception ex) { day = 1; }

            var dayName = $"day{day}";
            var dayPath = Path.Combine(srcPath, dayName);
            var relativeDayPath = Path.GetRelativePath(Directory.GetCurrentDirectory(), dayPath);

            try { Directory.Delete(dayPath); } catch (Exception ex) { }
            try { Directory.CreateDirectory(dayPath); } catch (Exception ex) { }

            Config.Dsa.ForEach(ds =>
            {
                if (Dsa.Modules.TryGetValue(ds, out var item))
                {
                    if (item == null)
                    {
                        throw new Exception($"Algorithm {ds} not found");
                    }
                    else
                    {
                        // Are we constructing a class, or a test class./
                        if (item.Type == ModuleType.Class)
                        {
                            CreateClass(ds, item, dayPath);
                        }
                    }
                }
            });
        }
    }
}
