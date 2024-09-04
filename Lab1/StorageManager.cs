using Lab1.Storages.Interface;

namespace Lab1;

public class StorageManager
{
    private static StorageManager _instance;
    private IStorage _currentStorage;

    private StorageManager() { }

    public static StorageManager Instance
    {
        get
        {
            if (_instance is null)
            {
                _instance = new StorageManager();
            }
            return _instance;
        }
    }

    public void SetStorage(IStorage storage)
    {
        _currentStorage = storage;
    }

    public void ConnectToStorage()
    {
        _currentStorage?.Connect();
    }

    public void DisconnectFromStorage()
    {
        _currentStorage?.Disconnect();
    }

    public void SaveFile(string fileName, byte[] fileData)
    {
        _currentStorage?.SaveFile(fileName, fileData);
    }

    public byte[] LoadFile(string fileName)
    {
        return _currentStorage.LoadFile(fileName);
    }
}
