using DesafioIndustriALL.Domain.Enums;

namespace DesafioIndustriALL.Domain.Entities
{
    public class PurchaseOrder
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status { get; set; }
        public User CreatedBy {  get; set; }
        public List<OrderItem> Items { get; set; }
        public List<Approval> Approvals { get; set; }
        public List<OrderHistory> History { get; set; }    
    }
}
