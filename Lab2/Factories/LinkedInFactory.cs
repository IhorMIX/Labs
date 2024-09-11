using Lab2.Networks;

namespace Lab2.Factories;

public class LinkedInFactory : SocialNetworkFactory
{
    public override ISocialNetwork CreateSocialNetwork()
    {
        return new LinkedIn();
    }
}