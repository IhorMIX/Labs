public class OrderUpdater : EntityUpdater
{
    private int _orderId;
    private string _status;
    private decimal _totalAmount;
    
    public OrderUpdater(int orderId, string status, decimal totalAmount)
    {
        _orderId = orderId;
        _status = status;
        _totalAmount = totalAmount;
    }
    protected override object GetEntity()
    {
        // get data
        return new 
        { 
            OrderId = _orderId, 
            Status = _status, 
            TotalAmount = _totalAmount 
        };
    }

    protected override bool ValidateEntity(object entity)
    {
        // validation TotalAmount > 0
        var order = (dynamic)entity;
        bool isValid = order.TotalAmount > 0;

        if (!isValid)
        {
            Console.WriteLine("Sum of order have to more than 0.");
        }
        return isValid;
    }

    protected override void SaveEntity(object entity)
    {
        // save order
        Console.WriteLine($"Order with ID {((dynamic)entity).OrderId} successfully saved with status '{((dynamic)entity).Status}'.");
    }

    protected override void OnSuccess()
    {
        // json
        var order = (dynamic)GetEntity();
        Console.WriteLine($"Order successfully saved. {{ \"OrderId\": {order.OrderId}, \"Status\": \"{order.Status}\", \"TotalAmount\": {order.TotalAmount} }}");
    }
}