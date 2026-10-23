using System;

namespace RefactoringLab.Part01.src;

public interface INotification
{
    string ChannelName { get; }
    public void Send(string to, string message, DateTime? sendAt = null); 
}
