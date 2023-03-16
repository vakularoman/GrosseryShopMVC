namespace GrosseryShopMVC.Repository
{
    using GrosseryShopMVC.DbSetUp;
    using GrosseryShopMVC.Models;
    using GrosseryShopMVC.Repository.Interfaces;

    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(Context context)
            : base(context)
        {
        }
    }
}
