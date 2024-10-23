class Program
{
    static void Main(string[] args)
    {
        // product
        Console.WriteLine("Update product:");
        var productUpdater = new ProductUpdater("fish", 150);
        productUpdater.UpdateEntity();
        Console.WriteLine("---");
        var productUpdater2 = new ProductUpdater("fish", 0);
        productUpdater2.UpdateEntity(); // exception that price <= 0

        // user
        Console.WriteLine("\nUpdate user:");
        var userUpdater = new UserUpdater("Ihor", "ihor@example.com", "ihor@example.com");
        userUpdater.UpdateEntity();
        Console.WriteLine("---");
        var userUpdater2 = new UserUpdater("Ihor", "ihor@example.com", "ihor1@example.com");
        userUpdater2.UpdateEntity(); // exception cuz current email is not equals new email

        // order
        Console.WriteLine("\nUpdate order:");
        var orderUpdater = new OrderUpdater(123, "Processing", 300);
        orderUpdater.UpdateEntity();
    }
}