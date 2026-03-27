using DesafioIndustriALL.Domain.Enums;

namespace DesafioIndustriALL.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required UserRole Role { get; set; }
    }
}
