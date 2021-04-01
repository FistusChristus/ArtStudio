using System.Security.Claims;
using System.Threading.Tasks;
using ArtStudio.Services;
using Microsoft.AspNetCore.Components.Authorization;

public class AuthStateProvider : AuthenticationStateProvider
{
    private readonly SessionService sessionService;
    public AuthStateProvider(SessionService sessionService)
    {
        this.sessionService = sessionService;
    }
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
    
        return Task.FromResult(new AuthenticationState(sessionService.GetSession().User));
    }
}