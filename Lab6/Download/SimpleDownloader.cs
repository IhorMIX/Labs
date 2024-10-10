using Lab6.Download.Interface;

namespace Lab6.Download;

public class SimpleDownloader : IDownloader
{
    public byte[] Download(string fileUrl)
    {
        Console.WriteLine($"Download {fileUrl} from network");
        return new byte[] { };
    }
}