using RefactoringLab.Part01.src;

namespace RefactoringLab;

public class ShippingCostCalculator
{
    private readonly ICarrier _carrier;
    public ShippingCostCalculator(ICarrier carrier)
    {
        _carrier = carrier ?? throw new ArgumentNullException(nameof(carrier));
    }

    public decimal Calculate(decimal weightKg)
    { 
        return _carrier.Calculate(weightKg);
    }
}

public class Aramex : ICarrier
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 12m;
    }
}

public class FedEx : ICarrier
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 15m;
    }
}

public class DHL : ICarrier
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 18m;
    }
}

public class UPS : ICarrier
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 20m;
    }
}