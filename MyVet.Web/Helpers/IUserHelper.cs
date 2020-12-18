using Microsoft.AspNetCore.Identity;
using MyVet.Web.Data.Entities;
using System.Threading.Tasks;

namespace MyVet.Web.Helpers
{
    interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string Password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRolesAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);




    }
}
