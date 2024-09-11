namespace Lab2.Networks;

public class LinkedIn : ISocialNetwork
{
    public void Login(string email, string password)
    {
        Console.WriteLine($"Logged in to LinkedIn with email: {email}");
    }

    public void PostMessage(string message)
    {
        Console.WriteLine($"Posted message to LinkedIn: {message}");
    }
}
