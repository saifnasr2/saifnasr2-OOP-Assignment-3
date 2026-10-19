using RefactoringLab.Part01.src;

namespace RefactoringLab;

public class OrderProcessor
{
    private readonly IOrderRepository _orderRepository;
    private readonly IEmailSender _emailSender;

    public OrderProcessor(IOrderRepository orderRepository, IEmailSender emailSender)
    {
        _orderRepository = orderRepository;
        _emailSender = emailSender;
    }

    public void Process(int orderId, string customerEmail)
    {
        DateTime processedAt = DateTime.Now;
        string body = $"Order {orderId} confirmed at {processedAt}";
        
        _orderRepository.Save(orderId, processedAt);
        _emailSender.Send(customerEmail, body);
    }
}

public class SqlOrderRepository : IOrderRepository
{
    public void Save(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}

public class SmtpEmailSender : IEmailSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}
