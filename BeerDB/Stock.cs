using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerDB
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }

        [ForeignKey("Beer")]
        public int BeerID { get; set; }

        public Beer Beer { get; set; }

        [ForeignKey("Shop")]
        public int ShopID { get; set; }
        public Shop Shop { get; set; }


        public double Price { get; set; }


        public override string ToString()
        {
            return "Stock ID: " + StockID +
                   "Beer ID: " + BeerID +
                   "\nShop ID " + ShopID +
                          "\nPrice: " + Price;
        }
    }
}
