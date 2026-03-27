using DesafioIndustriALL.Application.DTOs;
using DesafioIndustriALL.Domain.Entities;
using DesafioIndustriALL.Domain.Enums;

namespace DesafioIndustriALL.Application.Interfaces
{
    public interface IUserRepository
    {
        void CreateUser(UserDTO user);
        bool SaveUser();
        List<User> GetAllUsers();
    }
}
