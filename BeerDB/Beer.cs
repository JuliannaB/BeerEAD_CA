using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerDB
{
    public enum Container { Bottle, Can }

    public class Beer
    {
        [Key]
        public int BeerID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Style { get; set; }
        public string Brand { get; set; }
        public string Brewery { get; set; }
        public Container Container { get; set; }
        [Required]
        public int Volume { get; set; }
        [Required]
        public double ABV { get; set; }



        public override string ToString()
        {
            return "Beer ID: " + BeerID +
                   "\nName: " + Name +
                   "\nStyle: " + Style +
                   "\nBrand: " + Brand +
                   "\nBrewery: " + Brewery +
                   "\nContainer: " + Container +
                    "\nVolume: " + Volume + " ml" +
                   "\nABV: " + ABV + "%";
        }
    }
}
