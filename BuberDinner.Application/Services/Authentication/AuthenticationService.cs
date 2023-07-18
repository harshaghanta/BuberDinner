using BuberDinner.Application.Services.Authentication;

namespace BubDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "firstname", "lastname", email, "token");
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        throw new NotImplementedException();
    }
}