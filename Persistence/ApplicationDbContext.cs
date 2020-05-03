using Microsoft.EntityFrameworkCore;
using PointFood.Model;
using PointFood.Persistence.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Dish_extra> Dish_extra { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Reservation> Reservations{ get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantOwner> RestaurantOwners { get; set; }
        public DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new CardConfig(builder.Entity<Card>());
            new ClientConfig(builder.Entity<Client>());
            new DishConfig(builder.Entity<Dish>());
            new Dish_extraConfig(builder.Entity<Dish_extra>());
            new ExtraConfig(builder.Entity<Extra>());
            new OrderConfig(builder.Entity<Order>());
            new OrderDetailConfig(builder.Entity<OrderDetail>());
            new RestaurantConfig(builder.Entity<Restaurant>());
            new RestaurantOwnerConfig(builder.Entity<RestaurantOwner>());
            new TableConfig(builder.Entity<Table>());
        }
    }
}
