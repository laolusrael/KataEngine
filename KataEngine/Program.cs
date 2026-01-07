using KataEngine.CodeGen;

namespace KataEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("CWD \t- {0}", Directory.GetCurrentDirectory());

            if(args.Length == 0)
            {
                return;
            }

            switch (args[0].ToLowerInvariant()) 
            {
                case "generate":
                    Console.WriteLine("Generating DSA stubs ...");
                    new Generator().Generate(
                        Path.Combine(Directory.GetCurrentDirectory(), "KataEngine", "Dsa"));
                    break;
                case "clean" or "clear":
                    Console.WriteLine("Cleaning algorithm files ...");
                    new Clear().Clean(
                        Path.Combine(Directory.GetCurrentDirectory(), "KataEngine", "Dsa"));
                    break;
                default:
                    Console.WriteLine("RUN ./kataengine generate|clean");
                    Console.WriteLine("\t generates|cleans dsa stubs for you");
                    break;
            }
        }
    }
}
