using Lab2.Networks;

namespace Lab2.Factories;

public class FacebookFactory : SocialNetworkFactory
{
    public override ISocialNetwork CreateSocialNetwork()
    {
        return new Facebook();
    }
}