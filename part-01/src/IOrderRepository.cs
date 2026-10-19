using System;

namespace RefactoringLab.Part01.src;

public interface IOrderRepository
{
    public void Save(int orderId, DateTime processedAt);
}
