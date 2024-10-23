public class ProductUpdater : EntityUpdater
{
    private string _name;
    private decimal _price;
    
    public ProductUpdater(string name, decimal price)
    {
        _name = name;
        _price = price;
    }
    protected override object GetEntity()
    {
        return new 
        { 
            Name = _name, 
            Price = _price 
        };
    }

    protected override bool ValidateEntity(object entity)
    {
        // validation name is not empty and price > 0
        var product = (dynamic)entity;
        bool isValid = !string.IsNullOrWhiteSpace(product.Name) && product.Price > 0;

        if (!isValid)
        {
            Console.WriteLine("The name cannot be empty and price must more than 0.");
        }
        return isValid;
    }

    protected override void SaveEntity(object entity)
    {
        // save
        Console.WriteLine($"Order '{((dynamic)entity).Name}' with price {((dynamic)entity).Price} successfully saved.");
    }

    protected override void OnValidationFailed()
    {
        // OnValidationFailed
        Console.WriteLine("The administrator has been notified that the product has not been validated..");
    }
}