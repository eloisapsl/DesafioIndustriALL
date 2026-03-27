using DesafioIndustriALL.Domain.Enums;

namespace DesafioIndustriALL.Domain.Entities
{
    public class Approval
    {
        public Guid Id { get; set; }
        public Guid PurchaseOrderId { get; set; }
        public int Sequence { get; set; }
        public ApprovalStatus Status { get; set; }
        public Guid ApprovedByUserId { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
