public class UserUpdater : EntityUpdater
{
    private string _name;
    private string _currentEmail;
    private string _newEmail;
    
    public UserUpdater(string name, string currentEmail, string newEmail)
    {
        _name = name;
        _currentEmail = currentEmail;
        _newEmail = newEmail;
    }
    protected override object GetEntity()
    {
        // example to get data
        return new 
        { 
            Name = _name, 
            CurrentEmail = _currentEmail, 
            NewEmail = _newEmail 
        };
    }

    protected override bool ValidateEntity(object entity)
    {
        // check if name is not empty
        var user = (dynamic)entity;
        bool isValid = !string.IsNullOrWhiteSpace(user.Name);

        if (!isValid)
        {
            Console.WriteLine("The name cannot be empty");
        }

        // validation for email
        if (user.NewEmail != user.CurrentEmail)
        {
            Console.WriteLine("The email field cannot be changed.");
            isValid = false;
        }

        return isValid;
    }

    protected override void SaveEntity(object entity)
    {
        // save user
        Console.WriteLine($"User '{((dynamic)entity).Name}' successfully saved.");
    }
}
