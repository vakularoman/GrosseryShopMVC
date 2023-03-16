namespace GrosseryShopMVC.Repository
{
    using GrosseryShopMVC.DbSetUp;
    using GrosseryShopMVC.Models;
    using GrosseryShopMVC.Repository.Interfaces;

    public class FavoriteProductRepository : RepositoryBase<FavoriteProduct>, IFavoriteProductRepository
    {
        public FavoriteProductRepository(Context context)
            : base(context)
        {
        }
    }
}
