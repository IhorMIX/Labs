using Lab1;
using Lab1.Storages;
using Lab1.Storages.Interface;

IStorage localStorage = new LocalDiskStorage("C:\\Files");
StorageManager.Instance.SetStorage(localStorage);

StorageManager.Instance.ConnectToStorage();

StorageManager.Instance.SaveFile("file.txt", new byte[] { 0x01, 0x02, 0x03 });

byte[] fileData = StorageManager.Instance.LoadFile("file.txt");

StorageManager.Instance.DisconnectFromStorage();