using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BEERME.Models
{
    public class Stock
    {
        public int StockID { get; set; }

        public int BeerID { get; set; }

        public int ShopID { get; set; }

        public double Price { get; set; }

        public double PricePerUnit
        {
            get
            {
                return Math.Pow((((Beer.Volume * (Beer.ABV / 100)) / 10)) / Price, 2);
            }
            set
            {
                value = PricePerUnit;
            }
        }

        public virtual Beer Beer { get; set; }
        public virtual Shop Shop { get; set; }

    }
}