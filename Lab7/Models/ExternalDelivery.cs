using Lab7.Models.Interface;

namespace Lab7.Models;

public class ExternalDeliveryStrategy : IDeliveryStrategy
{
    public decimal CalculateDeliveryCost(decimal orderAmount)
    {
        return 50;
    }
}
