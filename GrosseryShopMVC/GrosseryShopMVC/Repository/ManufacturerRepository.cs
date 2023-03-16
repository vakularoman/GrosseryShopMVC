namespace GrosseryShopMVC.Repository
{
    using GrosseryShopMVC.DbSetUp;
    using GrosseryShopMVC.Models;
    using GrosseryShopMVC.Repository.Interfaces;

    public class ManufacturerRepository : RepositoryBase<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(Context context)
            : base(context)
        {
        }
    }
}
