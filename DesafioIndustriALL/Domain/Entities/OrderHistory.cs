using DesafioIndustriALL.Domain.Enums;

namespace DesafioIndustriALL.Domain.Entities
{
    public class OrderHistory
    {
        public Guid Id { get; set; }
        public Guid PurchaseOrderId { get; set; }
        public Guid UserId { get; set; }
        public HistoryActionType ActionType { get; set; }
        public DateTime Ocurrence { get; set; }
        public string Description { get; set; }
    }
}
