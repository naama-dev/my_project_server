using DAL.Interface;
using Models.Models;
using Microsoft.EntityFrameworkCore;
namespace DAL.Data
{
    public class UserData:IUser
    {
        private readonly DataProjectContext _context;

        public UserData(DataProjectContext context)
        {
            _context = context;
        }
        public async Task<List<User>> getAllUsers()
        {
            var users = await _context.User.ToListAsync();
            return users;
        }
    }
}
