using GameAPI.Entities;
using GameAPI.Models;

namespace GameAPI.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDTO request);
        Task<string?> LoginAsync(UserDTO request);
    }
}
