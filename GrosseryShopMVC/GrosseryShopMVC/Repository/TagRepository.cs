namespace GrosseryShopMVC.Repository
{
    using GrosseryShopMVC.DbSetUp;
    using GrosseryShopMVC.Models;
    using GrosseryShopMVC.Repository.Interfaces;

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(Context context)
            : base(context)
        {
        }
    }
}
