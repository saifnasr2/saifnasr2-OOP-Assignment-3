namespace RefactoringLab.Part02.Enrollment;

public class EnrollmentFacade
{
    private readonly PaymentGateway _payment;
    private readonly InvoiceGenerator _invoice;
    private readonly SeatInventory _seats;
    private readonly EmailService _email;

    public EnrollmentFacade(PaymentGateway payment, InvoiceGenerator invoice, SeatInventory seat, EmailService email)
    {
        _payment = payment ?? throw new ArgumentNullException(nameof(payment));
        _invoice = invoice ?? throw new ArgumentNullException(nameof(invoice));
        _seats = seat ?? throw new ArgumentNullException(nameof(seat));
        _email = email ?? throw new ArgumentNullException(nameof(email));
    }

    public void Enroll(string studentId, string courseId, decimal amount)
    {
        _payment.Charge(studentId, amount);
        _seats.Reserve(courseId, studentId);
        var invoiceId = _invoice.Create(studentId, amount);
        _email.Send(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");
    }
}
