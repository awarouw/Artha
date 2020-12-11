using Artha.Shared.ViewModels;
using System.Threading.Tasks;

namespace Artha.Client.Services.Interface
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);
    }
}
