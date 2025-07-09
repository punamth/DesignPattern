using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter notification type (email/sms):");
        string? type = Console.ReadLine();

        Console.WriteLine("Enter your message:");
        string? message = Console.ReadLine();

        var notifier = NotificationFactory.Create(type);

        if (notifier == null)
        {
            Console.WriteLine("❌ Invalid notification type.");
        }
        else if (string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine("❌ Message cannot be empty.");
        }
        else
        {
            notifier.Send(message);
        }

    }
}
