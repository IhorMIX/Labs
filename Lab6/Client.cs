using Lab6.Download;
using Lab6.Download.Interface;

namespace Lab6;

public class Client
{
    public void RenderPage(bool useCache, string fileUrl)
    {
        IDownloader downloader;

        if (useCache)
        {
            downloader = new CachedDownloader(new SimpleDownloader()); // caching
        }
        else
        {
            downloader = new SimpleDownloader(); // without caching
        }

        byte[] data = downloader.Download(fileUrl);
        
        Console.WriteLine($"Render page with data {fileUrl}");
    }
}
