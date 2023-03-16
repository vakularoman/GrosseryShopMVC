namespace GrosseryShopMVC.Models
{
    public class OrderToProduct
    {
        #region [main properties]
        public long OrderToProductId { get; set; }

        public long ProductId { get; set; }

        public long OrderId { get; set; }

        public int Count { get; set; }
        #endregion

        #region [navigation properties]
        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
        #endregion
    }
}
