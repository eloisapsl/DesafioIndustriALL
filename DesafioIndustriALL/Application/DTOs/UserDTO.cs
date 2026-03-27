using DesafioIndustriALL.Domain.Enums;

namespace DesafioIndustriALL.Application.DTOs
{
    public class UserDTO
    {
        public required string Name { get; set; }
        public required UserRole Role { get; set; }
    }
}
