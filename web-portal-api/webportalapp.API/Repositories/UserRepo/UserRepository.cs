using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using webportalapp.API.Dtos.User;
using webportalapp.Domain.Entities;
using webportalapp.Infrastructure.Persistence.PostgreSQL;

namespace webportalapp.API.Repositories.UserRepo
{
    public class UserRepository : IUserRepository
    {
        private readonly AppSQLContext _context;
        public UserRepository(AppSQLContext context) {
           _context = context;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
        public async Task<User> UpdateAsync(int id, UpdateUserRequestDto userDto)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(x => x.UID == id);

            if (existingUser == null)
            {
                return null;
            }

            existingUser.Username = userDto.Username;
            existingUser.Password = userDto.Password;
            existingUser.Email = userDto.Email;

           await _context.SaveChangesAsync();

            return existingUser;
        }
        public async Task<User?> CreateAsync(User userModel)
        {
            await _context.Users.AddAsync(userModel);
            await _context.SaveChangesAsync();
            return userModel;
        }

        public async Task<User?> DeleteAsync(int id)
        {
            var userModel = await _context.Users.FirstOrDefaultAsync(x => x.UID == id);

            if (userModel == null) {
                return null;
            }

             _context.Users.Remove(userModel);
            await _context.SaveChangesAsync();

            return userModel;
        }
    }
}
