namespace Lab2.Networks;

public interface ISocialNetwork
{
    void Login(string login, string password);
    void PostMessage(string message);
}