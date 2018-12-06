using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BEERME.Models
{
    public class Shop
    {
        [Key]
        public int ShopID { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}