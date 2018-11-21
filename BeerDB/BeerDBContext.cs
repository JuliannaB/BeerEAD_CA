using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BeerDB
{
    class BeerDBContext: DbContext
    {
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Stock> Stocks { get; set; }
    }
}
