using webportalapp.API.Dtos.User;
using webportalapp.Domain.Entities;

namespace webportalapp.API.Repositories.UserRepo
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();

        Task<User?> GetByIdAsync(int id);

        Task<User> UpdateAsync(int id, UpdateUserRequestDto userDto);

        Task<User?> CreateAsync(User userModel);

        Task<User?> DeleteAsync(int id);
    }
}
