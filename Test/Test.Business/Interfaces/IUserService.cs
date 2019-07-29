using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Data.Entities;

namespace Test.Business.Interfaces
{
    public interface IUserService
    {
        Task<User> AuthenticateAsync(string username, string password);
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> CreateAsync(User user, string password);
        Task UpdateAsync(User user, string password = null);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}
