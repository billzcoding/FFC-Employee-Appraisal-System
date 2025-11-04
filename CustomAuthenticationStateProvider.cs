// File: Services/CustomAuthenticationStateProvider.cs
using AppraisalAppV1.Services;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly SessionState _sessionState;

    public CustomAuthenticationStateProvider(SessionState sessionState)
    {
        _sessionState = sessionState;
        _sessionState.OnChange += NotifyAuthenticationStateChanged;
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var identity = new ClaimsIdentity();
        if (_sessionState.IsLoggedIn && _sessionState.CurrentUser != null)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, _sessionState.CurrentUser.Username),
                new Claim(ClaimTypes.GivenName, _sessionState.CurrentUser.FullName)
            };
            identity = new ClaimsIdentity(claims, "CustomAuth");
        }
        var user = new ClaimsPrincipal(identity);
        return Task.FromResult(new AuthenticationState(user));
    }

    public void NotifyAuthenticationStateChanged()
    {
        var authState = GetAuthenticationStateAsync();
        NotifyAuthenticationStateChanged(authState);
    }
}
