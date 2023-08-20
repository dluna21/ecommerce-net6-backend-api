using api_online_shop.Configuracion;
using CB.Entidades;
using Microsoft.EntityFrameworkCore;

namespace api_online_shop.context
{
    public class OnlineShopDataContext: DbContext 
    { 
   
        //DbContextOptions<OnlineShopDataContext> options,
        public OnlineShopDataContext(DbContextOptions<OnlineShopDataContext> options) : base(options)
        { 
        }
       
        public DbSet<OnlineShop> onlineShop { get; set; }
        public DbSet<testModel> test { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new Configuracion.testMap());
            modelBuilder.ApplyConfiguration(new Configuracion.OnlineShopMap1());
        }

       
    }
}
