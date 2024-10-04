using Lab4.Notification.Interface;

namespace Lab4.Notification;

public class EmailNotification : INotification
{
    private string _adminEmail;

    public EmailNotification(string adminEmail)
    {
        _adminEmail = adminEmail;
    }

    public void Send(string title, string message)
    {
        Console.WriteLine($"Sent email with title '{title}' to '{_adminEmail}' that says '{message}'.");
    }
}
