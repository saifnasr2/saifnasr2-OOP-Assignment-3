using RefactoringLab.Part01.src;

namespace RefactoringLab;

internal static class NotificationOutput
{
    public static void Send(string channel, string to, string message, DateTime? sendAt = null)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine($"[{channel} scheduled {sendAt.Value:g}] {to}: {message}");
        }
        else
        {
            System.Console.WriteLine($"[{channel} {to}: {message}]");
        }
    }
}

public class EmailNotification : INotification
{
    public string ChannelName => "email";   
    public void Send(string to, string message, DateTime? sendAt = null) =>
        NotificationOutput.Send(ChannelName, to, message, sendAt);
}

public class SmsNotification : INotification
{
    public string ChannelName => "SMS";

    public void Send(string to, string message, DateTime? sendAt = null) =>
        NotificationOutput.Send(ChannelName, to, message, sendAt);
}

public class WhatsAppNotification : INotification
{
    public string ChannelName => "WhatsApp";

    public void Send(string to, string message, DateTime? sendAt = null)
    {
        NotificationOutput.Send(ChannelName, to, message, sendAt);
    }
}

public class UrgentNotification : INotification
{
    private readonly INotification _inner;
    public string ChannelName => _inner.ChannelName;
    public UrgentNotification(INotification inner)
    {
        _inner = inner ?? throw new ArgumentNullException(nameof(inner));
    }

    
    public void Send(string to, string message, DateTime? sendAt = null)
    {
        _inner.Send(to, $"[URGENT] {message}", sendAt);
    }
        
}


public class ScheduledNotification : INotification
{
    private readonly INotification _inner;
    private readonly DateTime _sendAt;
    public string ChannelName => _inner.ChannelName;
    
    public ScheduledNotification(INotification inner, DateTime sendAt)
    {
        _inner = inner ?? throw new ArgumentNullException(nameof(inner));
        _sendAt = sendAt;
    }

    public void Send(string to, string message, DateTime? sendAt = null) =>
        _inner.Send(to, message, _sendAt);
}

