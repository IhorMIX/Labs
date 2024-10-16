using Lab7;
using Lab7.Models;

var orderAmount = 90m; // order price

var deliveryContext = new DeliveryContext();

// PickupStrategy
deliveryContext.SetStrategy(new PickupStrategy());
Console.WriteLine("PickupStrategy: " + deliveryContext.CalculateDeliveryCost(orderAmount));

// ExternalDeliveryStrategy
deliveryContext.SetStrategy(new ExternalDeliveryStrategy());
Console.WriteLine("ExternalDeliveryStrategy: " + deliveryContext.CalculateDeliveryCost(orderAmount));

// InternalDeliveryStrategy
deliveryContext.SetStrategy(new InternalDeliveryStrategy());
Console.WriteLine("InternalDeliveryStrategy: " + deliveryContext.CalculateDeliveryCost(orderAmount));

orderAmount = 110m;
// InternalDeliveryStrategy #2
deliveryContext.SetStrategy(new InternalDeliveryStrategy());
Console.WriteLine("InternalDeliveryStrategy: " + deliveryContext.CalculateDeliveryCost(orderAmount));