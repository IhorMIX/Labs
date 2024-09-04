namespace Lab1.Storages.Interface;

public interface IStorage
{
    void Connect();
    void Disconnect();
    void SaveFile(string fileName, byte[] fileData);
    byte[] LoadFile(string fileName);
}
