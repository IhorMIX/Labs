using Lab7.Models.Interface;

namespace Lab7.Models;

public class PickupStrategy : IDeliveryStrategy
{
    public decimal CalculateDeliveryCost(decimal orderAmount)
    {
        return 0;
    }
}
