using BubDinner.Application.Services.Authentication;
using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[ApiController]
[Route("auth")]

public class AuthenticationController : ControllerBase
{
    private IAuthenticationService _authenticationService
        ;
    public AuthenticationController(IAuthenticationService authenticationService)
    {
        this._authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest registerRequest)
    {
        AuthenticationResult authenticationResult = _authenticationService.Register(
            registerRequest.FirstName,
            registerRequest.LastName,
            registerRequest.Email,
            registerRequest.Password);

        AuthenticationResponse authenticationResponse = new AuthenticationResponse(
            authenticationResult.Id, authenticationResult.FirstName, authenticationResult.LastName, 
            authenticationResult.Email, authenticationResult.Token);
        
        return Ok(authenticationResponse);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest loginRequest)
    {
        AuthenticationResult authenticationResult = _authenticationService.Login(loginRequest.Email, loginRequest.Password);

        AuthenticationResponse authenticationResponse = new AuthenticationResponse(
           authenticationResult.Id, authenticationResult.FirstName, authenticationResult.LastName,
           authenticationResult.Email, authenticationResult.Token);

        return Ok(authenticationResponse);
    }

}