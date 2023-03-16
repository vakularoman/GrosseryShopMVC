namespace GrosseryShopMVC.Repository
{
    using GrosseryShopMVC.DbSetUp;
    using GrosseryShopMVC.Models;
    using GrosseryShopMVC.Repository.Interfaces;

    public class ProductToTagRepository : RepositoryBase<ProductToTag>, IProductToTagRepository
    {
        public ProductToTagRepository(Context context)
            : base(context)
        {
        }
    }
}
