namespace Lab2.Networks;

public class Facebook : ISocialNetwork
{
    public void Login(string login, string password)
    {
        Console.WriteLine($"Logged in to Facebook with login: {login}");
    }

    public void PostMessage(string message)
    {
        Console.WriteLine($"Posted message to Facebook: {message}");
    }
}
