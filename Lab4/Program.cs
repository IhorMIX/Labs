using Lab4.Notification;
using Lab4.Notification.Interface;

// email notification
INotification emailNotification = new EmailNotification("admin@example.com");
emailNotification.Send("Email Title", "This is an email message");

// Slack notification
INotification slackNotification = new SlackNotification("login", "apiKey", "chat123");
slackNotification.Send("Slack Title", "This is a Slack message");

// SMS notification
INotification smsNotification = new SmsNotification("123-456-7890", "Ihor");
smsNotification.Send("SMS Title", "This is an SMS message");