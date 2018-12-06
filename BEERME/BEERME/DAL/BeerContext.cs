using BEERME.Models;
using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BEERME.DAL
{
    public class BeerContext : DbContext
    {
        public BeerContext() : base("BeerContext")
        {

        }

        public DbSet<Beer> Beers { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Shop> Shops { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}