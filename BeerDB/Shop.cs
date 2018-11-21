using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerDB
{
    public class Shop
    {
        [Key]
        public int ShopID { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }



        public override string ToString()
        {
            return "ShopID: " + ShopID +
                    "Shop Name: " + ShopName +
                    "Shop Address: " + ShopAddress;
        }
    }
}
