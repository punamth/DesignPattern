class Program
{
    static void Main()
    {
        var channel = new Channel();

        var allSubscribers = new Dictionary<string, Subscriber>();

        while (true)
        {
            Console.WriteLine("\n========== YouTube Channel Menu ==========");
            Console.WriteLine("1. Subscribe");
            Console.WriteLine("2. Unsubscribe");
            Console.WriteLine("3. Upload Video");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter subscriber name: ");
                    string? subName = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(subName))
                    {
                        if (!allSubscribers.ContainsKey(subName))
                        {
                            var newSub = new Subscriber(subName);
                            allSubscribers[subName] = newSub;
                            channel.Subscribe(newSub);
                            Console.WriteLine($"✅ {subName} subscribed.");
                        }
                        else
                        {
                            Console.WriteLine($"⚠️ {subName} is already subscribed.");
                        }
                    }
                    break;

                case "2":
                    Console.Write("Enter subscriber name to unsubscribe: ");
                    string? unsubName = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(unsubName) && allSubscribers.ContainsKey(unsubName))
                    {
                        channel.Unsubscribe(allSubscribers[unsubName]);
                        allSubscribers.Remove(unsubName);
                        Console.WriteLine($"❌ {unsubName} unsubscribed.");
                    }
                    else
                    {
                        Console.WriteLine($"⚠️ {unsubName} is not in subscriber list.");
                    }
                    break;

                case "3":
                    Console.Write("🎬 Enter video title to upload: ");
                    string? videoTitle = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(videoTitle))
                    {
                        channel.UploadVideo(videoTitle);
                    }
                    else
                    {
                        Console.WriteLine("⚠️ Video title cannot be empty.");
                    }
                    break;

                case "4":
                    Console.WriteLine("👋 Exiting... bye!");
                    return;

                default:
                    Console.WriteLine("❓ Invalid option. Try again.");
                    break;
            }
        }

        Console.ReadKey();
    }
}
