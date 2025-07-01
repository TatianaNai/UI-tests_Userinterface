namespace UserinterfaceUtilities.Utilities
{
    public static class PathUtils
    {
        public static string GetFullPathFromCurrentDirectory(string path) => @$"{Directory.GetCurrentDirectory()}\{path}";
    }
}
