using CB.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CB.Persistencia.Configuraciones;
using Pro.Data.Core;

namespace CB.Persistencia.Context
{
    public class OnlineShopContext: DbContext, IDbContext
    {
        private readonly string _connstr;

        public OnlineShopContext(string connstr) {
            this._connstr = connstr;
        }

        //public OnlineShopContext(DbContextOptions<OnlineShopContext> options) : base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!string.IsNullOrWhiteSpace(this._connstr))
            {

                optionsBuilder
                    //.UseLoggerFactory(factory)
                    //.EnableSensitiveDataLogging()
                    .UseNpgsql(this._connstr, npgsqlOptionsAction: sqlOptions =>
                    {
                        //sqlOptions.CommandTimeout((int)TimeSpan.FromSeconds(5).TotalSeconds);
                    });
            }

            //base.OnConfiguring(optionsBuilder);
        }
        public DbSet<OnlineShop> onlineShop { get; set; }
        public DbSet<testModel> test { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new testMap());
            modelBuilder.ApplyConfiguration(new OnlineShopMap());

        }

        public Task EnsureAutoHistoryExtension()
        {
            throw new NotImplementedException();
        }
    }
}
