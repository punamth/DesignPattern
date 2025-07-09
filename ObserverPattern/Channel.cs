public class Channel : IChannel
{
    private List<ISubscriber> _subscribers = new();

    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void UploadVideo(string title)
    {
        Console.WriteLine($"Channel uploaded: {title}");
        foreach (var sub in _subscribers)
        {
            sub.Notify(title);
        }
    }
}
