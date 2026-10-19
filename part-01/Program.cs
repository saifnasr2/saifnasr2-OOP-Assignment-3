using RefactoringLab;

var aramex = new ShippingCostCalculator(new Aramex());
var fedEx = new ShippingCostCalculator(new FedEx());
var ups = new ShippingCostCalculator(new UPS());

Console.WriteLine($"Aramex 2kg → {aramex.Calculate(2)}");
Console.WriteLine($"FedEx 2kg → {fedEx.Calculate(2)}");
Console.WriteLine($"UPS 2kg → {ups.Calculate(2)}");
Console.WriteLine();

// var orderRepository = new SqlOrderRepository();
// var emailSender = new SmtpEmailSender();
// var processor = new OrderProcessor(orderRepository, emailSender);
// processor.Process(1001, "customer@example.com");
// Console.WriteLine();

// new ScheduledNotification(new UrgentNotification(new EmailNotification()), DateTime.Today.AddHours(18))
//     .Send("customer@example.com", "Your order ships tomorrow");
// new UrgentNotification(new SmsNotification())
//     .Send("+201000000000", "OTP 4821");
