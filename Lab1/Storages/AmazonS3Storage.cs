using Lab1.Storages.Interface;

namespace Lab1.Storages;

public class AmazonS3Storage : IStorage
{
    private string _bucketName;

    public AmazonS3Storage(string bucketName)
    {
        _bucketName = bucketName;
    }

    public void Connect()
    {
   
    }

    public void Disconnect()
    {

    }

    public void SaveFile(string fileName, byte[] fileData)
    {
 
    }

    public byte[] LoadFile(string fileName)
    {
        return new byte[] { 0x00, 0x01, 0x02, 0x03 };
    }
}
