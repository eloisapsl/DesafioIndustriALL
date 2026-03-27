using DesafioIndustriALL.Application.DTOs;
using DesafioIndustriALL.Application.Interfaces;
using DesafioIndustriALL.Domain.Entities;
using DesafioIndustriALL.Domain.Enums;
using DesafioIndustriALL.Infrastructure.Data;

namespace DesafioIndustriALL.Application.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void CreateUser(UserDTO user)
        {
            var newUser = new User
            {
                Name = user.Name,
                Role = user.Role
            };
            context.User.Add(newUser);
        }

        public bool SaveUser()
        {
            return context.SaveChanges() > 0;
        }

        public List<User> GetAllUsers()
        {
            return context.User.ToList();
        }
    }
}
