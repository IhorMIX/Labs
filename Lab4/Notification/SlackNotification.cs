using Lab4.Notification.Interface;

namespace Lab4.Notification;

public class SlackNotification : INotification
{
    private string _login;
    private string _apiKey;
    private string _chatId;

    public SlackNotification(string login, string apiKey, string chatId)
    {
        _login = login;
        _apiKey = apiKey;
        _chatId = chatId;
    }

    public void Send(string title, string message)
    {
        Console.WriteLine($"Sent Slack message to chat '{_chatId}' with title '{title}' that says '{message}'.");
    }
}
