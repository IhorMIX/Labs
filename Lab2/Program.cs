﻿using Lab2.Factories;
using Lab2.Networks;

// facebook
SocialNetworkFactory facebookFactory = new FacebookFactory();
ISocialNetwork facebook = facebookFactory.CreateSocialNetwork();
facebook.Login("facebook_login", "facebook_password");
facebook.PostMessage("Hello, Facebook!");

// linkedIn
SocialNetworkFactory linkedInFactory = new LinkedInFactory();
ISocialNetwork linkedIn = linkedInFactory.CreateSocialNetwork();
linkedIn.Login("linkedin_email", "linkedin_password");
linkedIn.PostMessage("Hello, LinkedIn!");