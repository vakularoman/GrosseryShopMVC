namespace GrosseryShopMVC.Repository
{
    using GrosseryShopMVC.DbSetUp;
    using GrosseryShopMVC.Models;
    using GrosseryShopMVC.Repository.Interfaces;

    public class CartProductRepository : RepositoryBase<CartProduct>, ICartProductRepository
    {
        public CartProductRepository(Context context)
            : base(context)
        {
        }
    }
}
