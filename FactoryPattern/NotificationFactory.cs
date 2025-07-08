public static class NotificationFactory
{
    public static INotificationService? Create(string? type)
    {
        return type?.ToLower() switch
        {
            "email" => new EmailNotification(),
            "sms" => new SmsNotification(),
            _ => null
        };
    }
}
