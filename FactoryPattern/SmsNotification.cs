﻿public class SmsNotification : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine("SMS sent: " + message);
    }
}
