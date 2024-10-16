namespace Lab7.Models.Interface;

public interface IDeliveryStrategy
{
    decimal CalculateDeliveryCost(decimal orderAmount);
}
