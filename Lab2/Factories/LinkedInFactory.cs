using Lab2.Networks;

namespace Lab2.Factories;

public class LinkedInFactory : ISocialNetworkFactory
{
    public ISocialNetwork CreateSocialNetwork()
    {
        return new LinkedIn();
    }
}