namespace BuberDinner.Contracts.Authentication;

public record LoginRequest(
    string Email,
    String Password
);