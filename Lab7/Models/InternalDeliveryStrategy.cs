using Lab7.Models.Interface;

namespace Lab7.Models;

public class InternalDeliveryStrategy : IDeliveryStrategy
{
    public decimal CalculateDeliveryCost(decimal orderAmount)
    {
        return orderAmount > 100 ? 20 : 30; // if orderAmount has > 100 we take a discount, and we pay 20 otherwise - 30
    }
}
