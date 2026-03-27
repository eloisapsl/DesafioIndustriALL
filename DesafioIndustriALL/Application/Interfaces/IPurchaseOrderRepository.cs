using DesafioIndustriALL.Application.DTOs;
using DesafioIndustriALL.Domain.Entities;

namespace DesafioIndustriALL.Application.Interfaces
{
    public interface IPurchaseOrderRepository
    {
        void CreateOrder(UserDTO user);
        bool SaveUser();
        List<User> GetAllUsers();
    }
}
