namespace BuberDinner.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    String FirstName,
    String LastName,
    string Email,    
    String Token
);