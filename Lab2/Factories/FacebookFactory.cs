using Lab2.Networks;

namespace Lab2.Factories;

public class FacebookFactory : ISocialNetworkFactory
{
    public ISocialNetwork CreateSocialNetwork()
    {
        return new Facebook();
    }
}