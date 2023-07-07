using System.IdentityModel.Tokens.Jwt;
using Authentication.Models;

namespace Authentication.Services
{
    public interface IAuthenticationService
    {
        Task<string> Register (RegisterRequest request);
        Task<string> Login (LoginRequest request);
    }
}
