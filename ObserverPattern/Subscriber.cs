public class Subscriber: ISubscriber
{
    private string _name;

    public Subscriber(string name)
    {
        _name = name;
    }

    public void Notify(string videoTitle)
    {
        Console.WriteLine($"{_name}, new video uploaded: {videoTitle}");
    }

}