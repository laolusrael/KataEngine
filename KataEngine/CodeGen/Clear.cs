namespace KataEngine.CodeGen
{
    internal class Clear
    {
        public void Clean(string targetPath)
        {
            if(string.IsNullOrEmpty(targetPath))
            {
                return;
            }

            try
            {
                Directory.GetDirectories(targetPath).Where(f =>
                {
                    if (f.Contains("day"))
                    {
                        Console.WriteLine("Found {0}", f);
                        return true;
                    }
                    Console.WriteLine("Ignoring {0}", f);
                    return false;
                })
                    .ToList()
                    .ForEach(p =>
                    {
                        Console.WriteLine("Deleting {0}", p);
                        Directory.Delete(p, true);
                    });
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: {0}", ex);
            }
        }
    }
}
