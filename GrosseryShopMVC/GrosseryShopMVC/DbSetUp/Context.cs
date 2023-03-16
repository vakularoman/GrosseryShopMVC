namespace GrosseryShopMVC.DbSetUp
{
    using GrosseryShopMVC.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class Context : IdentityDbContext<User, Role, long>
    {
        public Context(DbContextOptions<Context> options)
         : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Nutrition> Nutritions { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<UserToPaymentSystem> UsersToPaymentSystems { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<ProductToTag> ProductsToTags { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<PaymentSystem> PaymentSystems { get; set; }

        public DbSet<OrderToProduct> OrdersToProducts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<CartProduct> CartProducts { get; set; }
    }
}
