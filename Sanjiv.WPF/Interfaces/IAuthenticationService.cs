using System.Threading.Tasks;
using Sanjiv.Common.Models;

namespace Sanjiv.WPF.Interfaces
{
    public interface IAuthenticationService
    {
        Task<UserReturnObject> AuthenticateUser(string username, string password);
    }
}
