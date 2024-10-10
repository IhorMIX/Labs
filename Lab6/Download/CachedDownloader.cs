using Lab6.Download.Interface;

namespace Lab6.Download;

public class CachedDownloader : IDownloader
{
    private readonly IDownloader _downloader;
    private readonly Dictionary<string, byte[]> _cache; //Collection tkey tvalue

    public CachedDownloader(IDownloader downloader)
    {
        _downloader = downloader;
        _cache = new Dictionary<string, byte[]>();
    }

    public byte[] Download(string fileUrl)
    {
        if (_cache.TryGetValue(fileUrl, out var download))
        {
            Console.WriteLine($"Return data's cached {fileUrl}");
            return download; // return form cache
        }

        var data = _downloader.Download(fileUrl); 
        _cache[fileUrl] = data; // add to cache

        return data;
    }
}
