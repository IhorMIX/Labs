using Lab7.Models.Interface;

namespace Lab7;

public class DeliveryContext
{
    private IDeliveryStrategy _strategy;

    public void SetStrategy(IDeliveryStrategy strategy)
    {
        _strategy = strategy;
    }

    public decimal CalculateDeliveryCost(decimal orderAmount)
    {
        return _strategy.CalculateDeliveryCost(orderAmount);
    }
}
