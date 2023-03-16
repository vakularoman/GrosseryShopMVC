namespace GrosseryShopMVC.Repository
{
    using GrosseryShopMVC.DbSetUp;
    using GrosseryShopMVC.Models;
    using GrosseryShopMVC.Repository.Interfaces;

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(Context context)
            : base(context)
        {
        }
    }
}
