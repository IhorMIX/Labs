using Lab6;

public class Program
{
    public static void Main(string[] args)
    {
        Client client = new Client();

        string fileUrl = "https://example.com/plug/file";

        Console.WriteLine("Render with caching logic:");
        client.RenderPage(useCache: true, fileUrl);

        Console.WriteLine("\nRender again but we have already used caching:");
        client.RenderPage(useCache: true, fileUrl);

        Console.WriteLine("\n Render without caching:");
        client.RenderPage(useCache: false, fileUrl);
    }
}