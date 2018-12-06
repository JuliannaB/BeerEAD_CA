using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BEERME.Models;

namespace BEERME.DAL
{
    public class BEERMEInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BEERMEContext>
    {
        protected override void Seed(BEERMEContext context)
        {
            var beers = new List<Beer>
            {
                new Beer { Name = "Darkside IPA", Style = "IPA - American", Brand = "Brú Brewery", Brewery = "Brú Brewery", Container = Container.Bottle, Volume = 500 , ABV = 5.2 },
                new Beer { Name = "Darragh's Session IPA", Style = "IPA - Session / India Session Ale", Brand = "McGargles", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 3.8 },
                new Beer { Name = "O'Hara's Irish Stout", Style = "Stout - Irish Dry", Brand = "O'Hara's", Brewery = "O'Hara's Brewery (Carlow Brewing Company)", Container = Container.Bottle, Volume = 500 , ABV = 4.3 },
                new Beer { Name = "Rye River Belgian Imperial Stout", Style = "Stout - Imperial / Double", Brand = "Rye River", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 8.2 },
                new Beer { Name = "The Crafty Brewing Company - Irish Red Ale", Style = "Red Ale - Irish", Brand = "The Crafty Brewing Company", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 4.1 },
                new Beer { Name = "Grafters IPA", Style = "IPA - American", Brand = "Grafters", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 6.5 },
                new Beer { Name = "O'Shea's IPA", Style = "IPA - English", Brand = "O'Shea's", Brewery = "O'Hara's Brewery (Carlow Brewing Company)", Container = Container.Bottle, Volume = 500 , ABV = 5 },
                new Beer { Name = "Brown Bear Double IPA", Style = "IPA - Imperial / Double", Brand = "Brown Bear", Brewery = "Station Works Brewery", Container = Container.Bottle, Volume = 500 , ABV = 6.3 },
                new Beer { Name = "Solas Hops & Grains Belgian Wit", Style = "Wit bier", Brand = "Solas Hops & Grains", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 5.2 },
                new Beer { Name = "Boyne Brewhouse Saison", Style = "Saison / Farmhouse Ale", Brand = "Boyne Brewhouse", Brewery = "Boyne Brewhouse", Container = Container.Bottle, Volume = 500 , ABV = 5.5 },
                new Beer { Name = "Ironmonger", Style = "IPA - English", Brand = "Metalman Brewing", Brewery = "Metalman Brewing", Container = Container.Can, Volume = 330 , ABV = 6.5 }
                
            };

            beers.ForEach(b => context.Beers.Add(b));
            context.SaveChanges();

            var shops = new List<Shop>
            {
                new Shop { ShopName = "Lidl", ShopAddress = "1 Moore St" },
                new Shop { ShopName = "Dunnes", ShopAddress = "62 Grafton Street" },
                new Shop { ShopName = "Tesco", ShopAddress = "Jervis St" },
                new Shop { ShopName = "Centra", ShopAddress = "35 Abbey Street Lower" }
            };

            shops.ForEach(b => context.Shops.Add(b));
            context.SaveChanges();

            var stocks = new List<Stock>
            {
                new Stock{ BeerID = 5, ShopID = 1, Price = 1.89 }
            };

            stocks.ForEach(b => context.Stocks.Add(b));
            context.SaveChanges();


        }
    }
}