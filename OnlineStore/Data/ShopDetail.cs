namespace OnlineStore.Data
{
    public class ShopDetail : BaseEntity
    {
        public int Quantity { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
