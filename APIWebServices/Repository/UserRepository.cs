using APIWebServices.Data;
using APIWebServices.Model;
using Microsoft.EntityFrameworkCore;

namespace APIWebServices.Repository
{
    public class UserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsers() => await _context.Users.ToListAsync();

        public async Task<User?> GetUserById(int id) => await _context.Users.FindAsync(id);

        public async Task AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
