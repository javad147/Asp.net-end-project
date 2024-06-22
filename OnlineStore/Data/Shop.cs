namespace OnlineStore.Data
{
    public class Shop : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<ShopDetail> ShopDetails { get; set; }
    }
}
