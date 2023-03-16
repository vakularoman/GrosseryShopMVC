namespace GrosseryShopMVC.Repository
{
    using GrosseryShopMVC.DbSetUp;
    using GrosseryShopMVC.Models;
    using GrosseryShopMVC.Repository.Interfaces;

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(Context context)
            : base(context)
        {
        }
    }
}
