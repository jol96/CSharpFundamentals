namespace Async
{
    public class FileReader
    {
        public static async Task<string> ReadFileAsync(string path)
        {
            var text = await File.ReadAllTextAsync(path).ConfigureAwait(false);

            return text;
        }
    }
}
