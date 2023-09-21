namespace SomeCSharpPractice;

public class PublisherSubscriber
{
    public static void DisplayResult()
    {
        var publisher = new Publisher();
        var subscriber1 = new Subscriber("Sub 1", publisher);
        var subscriber2 = new Subscriber("Sub 2", publisher);
        
        Console.WriteLine("The publisher is DOING THE THING.");
        publisher.DoTheThing();
        
        
    }
}

class MyEventArgs : EventArgs
{
    public MyEventArgs(string message)
    {
        Message = message;
    }
    public string Message { get; set; }
}

class Publisher
{
    public event EventHandler<MyEventArgs> RaiseMyEvent;

    public void DoTheThing()
    {
        Console.WriteLine("The publisher is doing some other itty gritty stuff here.");
        OnRaiseMyEvent(new MyEventArgs("My precious..."));
        Console.WriteLine("Proceed to throw the One Ring into the fire.");
    }

    protected virtual void OnRaiseMyEvent(MyEventArgs args)
    {
        EventHandler<MyEventArgs> raiseEvent = RaiseMyEvent;

        if (raiseEvent == null)
            return;
        
        args.Message += $"at {DateTime.Now}";
        raiseEvent(this, args);
    }
}

class Subscriber
{
    private readonly string _id;

    public Subscriber(string id, Publisher publisher)
    {
        _id = id;
        publisher.RaiseMyEvent += HandleMyEvent;
    }

    void HandleMyEvent(object sender, MyEventArgs args)
    {
        Console.WriteLine($"{_id} received this message: {args.Message}");
    }
}