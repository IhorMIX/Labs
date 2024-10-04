using Lab4.Notification.Interface;

namespace Lab4.Notification;

public class SmsNotification : INotification
{
    private string _phone;
    private string _sender;

    public SmsNotification(string phone, string sender)
    {
        _phone = phone;
        _sender = sender;
    }

    public void Send(string title, string message)
    {
        Console.WriteLine($"Sent SMS from '{_sender}' to '{_phone}' with title '{title}' that says '{message}'.");
    }
}
