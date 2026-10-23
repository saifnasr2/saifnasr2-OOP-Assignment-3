using System;

namespace RefactoringLab.Part01.src;

public interface IEmailSender
{
    public void Send(string to, string body);
}
