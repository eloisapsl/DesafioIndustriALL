namespace DesafioIndustriALL.Domain.Entities
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Guid PurchaseOrderId { get; set; }
    }
}
