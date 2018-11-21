using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerDB
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Beer b1 = new Beer()
                {
                    BeerID = 1,
                    Name = "Darkside IPA",
                    Style = "IPA - American",
                    Brand = "Brú Brewery",
                    Brewery = "Brú Brewery",
                    Container = Container.Bottle,
                    Volume = 500,
                    ABV = 5.2,
                };
                Beer b2 = new Beer()
                {
                    BeerID = 2,
                    Name = "Darragh's Session IPA",
                    Style = "IPA - Session / India Session Ale",
                    Brand = "McGargles",
                    Brewery = "Rye River Brewing Company",
                    Container = Container.Bottle,
                    Volume = 500,
                    ABV = 3.8,

                };

                Beer b3 = new Beer()
                {
                    BeerID = 3,
                    Name = "O'Hara's Irish Stout",
                    Style = "Stout - Irish Dry",
                    Brand = "O'Hara's",
                    Brewery = "O'Hara's Brewery(Carlow Brewing Company)",
                    Container = Container.Bottle,
                    Volume = 500,
                    ABV = 4.3,


                };
                Beer b4 = new Beer()
                {
                    BeerID = 4,
                    Name = "O'Hara's Irish Pale Ale",
                    Style = "IPA - International",
                    Brand = "O'Hara's",
                    Brewery = "O'Hara's Brewery(Carlow Brewing Company)",
                    Container = Container.Bottle,
                    Volume = 500,
                    ABV = 5.2,


                };
                Beer b5 = new Beer()
                {
                    BeerID = 5,
                    Name = "Rye River Ól Orange Lager",
                    Style = "Lager - IPL(India Pale Lager)",
                    Brand = "Rye River",
                    Brewery = "Rye River Brewing Company",
                    Container = Container.Can,
                    Volume = 500,
                    ABV = 4.4,


                };
                Beer b6 = new Beer()
                {
                    BeerID = 6,
                    Name = "Rye River Just the Tipple",
                    Style = "Saison / Farmhouse Ale",
                    Brand = "Rye River",
                    Brewery = "Rye River Brewing Company ",
                    Container = Container.Can,
                    Volume = 500,
                    ABV = 6.5,


                };
                Beer b7 = new Beer()
                {
                    BeerID = 7,
                    Name = "Rye River Miami J IPA",
                    Style = "IPA - New England",
                    Brand = "Rye River",
                    Brewery = "Rye River Brewing Company",
                    Container = Container.Can,
                    Volume = 500,
                    ABV = 6.5,


                };
                Beer b8 = new Beer()
                {
                    BeerID = 8,
                    Name = "Rye River Belgian Imperial Stout",
                    Style = "Stout - Imperial / Double",
                    Brand = "Rye River",
                    Brewery = "Rye River Brewing Company",
                    Container = Container.Bottle,
                    Volume = 500,
                    ABV = 8.2,


                };
                Beer b9 = new Beer()
                {
                    BeerID = 9,
                    Name = "The Crafty Brewing Company - Irish Red Ale",
                    Style = "Red Ale - Irish",
                    Brand = "The Crafty Brewing Company",
                    Brewery = "Rye River Brewing Company",
                    Container = Container.Bottle,
                    Volume = 500,
                    ABV = 4.1,

                };
                Beer b10 = new Beer()
                {
                    BeerID = 10,
                    Name = "The Crafty Brewing Company - Irish Pale Ale",
                    Style = "Pale Ale - Australian",
                    Brand = "The Crafty Brewing Company",
                    Brewery = "Rye River Brewing Company",
                    Container = Container.Bottle,
                    Volume = 500,
                    ABV = 4.5,


                };
                BeerDBContext BeerContext = new BeerDBContext();
                try
                {
                    BeerContext.Beers.Add(b1);
                    BeerContext.Beers.Add(b2);
                    BeerContext.Beers.Add(b3);
                    BeerContext.Beers.Add(b4);
                    BeerContext.Beers.Add(b5);
                    BeerContext.Beers.Add(b6);
                    BeerContext.Beers.Add(b7);
                    BeerContext.Beers.Add(b8);
                    BeerContext.Beers.Add(b9);
                    BeerContext.Beers.Add(b10);
                }
                catch (InvalidOperationException) { }
                BeerContext.SaveChanges();

                Shop s1 = new Shop() { ShopID = 1, ShopName = "Lidl", ShopAddress = "1 Moore St" };
                Shop s2 = new Shop() { ShopID = 2, ShopName = "Dunnes", ShopAddress = "62 Grafton Street" };
                Shop s3 = new Shop() { ShopID = 3, ShopName = "Tesco", ShopAddress = "Jervis St" };
                Shop s4 = new Shop() { ShopID = 4, ShopName = "Centra", ShopAddress = "35 Abbey Street Lower" };

                BeerDBContext ShopContext = new BeerDBContext();
                ShopContext.Shops.Add(s1);
                ShopContext.Shops.Add(s2);
                ShopContext.Shops.Add(s3);
                ShopContext.Shops.Add(s4);
                ShopContext.SaveChanges();

                Stock st1 = new Stock() { StockID = 1, BeerID = 1, Price = 2.35, ShopID = 1 };
                Stock st2 = new Stock() { StockID = 2, BeerID = 1, Price = 2.5, ShopID = 2 };
                Stock st3 = new Stock() { StockID = 3, BeerID = 1, Price = 2.7, ShopID = 3 };
                Stock st4 = new Stock() { StockID = 4, BeerID = 1, Price = 3.0, ShopID = 4 };

                Stock st5 = new Stock() { StockID = 5, BeerID = 2, Price = 2.7, ShopID = 1 };
                Stock st6 = new Stock() { StockID = 6, BeerID = 2, Price = 2.95, ShopID = 2 };
                Stock st7 = new Stock() { StockID = 7, BeerID = 2, Price = 2.5, ShopID = 3 };
                Stock st8 = new Stock() { StockID = 8, BeerID = 3, Price = 2.95, ShopID = 4 };

                Stock st9 = new Stock() { StockID = 9, BeerID = 3, Price = 2.55, ShopID = 1 };
                Stock st10 = new Stock() { StockID = 10, BeerID = 3, Price = 2.75, ShopID = 2 };
                Stock st11 = new Stock() { StockID = 11, BeerID = 3, Price = 2.49, ShopID = 3 };
                Stock st12 = new Stock() { StockID = 12, BeerID = 4, Price = 3.5, ShopID = 4 };

                Stock st13 = new Stock() { StockID = 13, BeerID = 4, Price = 3.7, ShopID = 2 };
                Stock st14 = new Stock() { StockID = 14, BeerID = 5, Price = 1.9, ShopID = 2 };
                Stock st15 = new Stock() { StockID = 15, BeerID = 5, Price = 2.4, ShopID = 3 };
                Stock st16 = new Stock() { StockID = 16, BeerID = 5, Price = 2.9, ShopID = 4 };
                Stock st17 = new Stock() { StockID = 17, BeerID = 6, Price = 2.5, ShopID = 3 };
                Stock st18 = new Stock() { StockID = 18, BeerID = 6, Price = 2.45, ShopID = 2 };
                Stock st19 = new Stock() { StockID = 19, BeerID = 7, Price = 2.85, ShopID = 4 };
                Stock st20 = new Stock() { StockID = 20, BeerID = 8, Price = 1.80, ShopID = 2 };
                Stock st21 = new Stock() { StockID = 21, BeerID = 8, Price = 2.3, ShopID = 4 };
                Stock st22 = new Stock() { StockID = 22, BeerID = 9, Price = 1.85, ShopID = 2 };
                Stock st23 = new Stock() { StockID = 23, BeerID = 9, Price = 2.0, ShopID = 3 };
                Stock st24 = new Stock() { StockID = 24, BeerID = 9, Price = 2.15, ShopID = 4 };
                Stock st25 = new Stock() { StockID = 25, BeerID = 10, Price = 2.05, ShopID = 1 };
                Stock st26 = new Stock() { StockID = 26, BeerID = 10, Price = 2.15, ShopID = 4 };


                BeerDBContext StockContext = new BeerDBContext();
                StockContext.Stocks.Add(st1);
                StockContext.Stocks.Add(st2);
                StockContext.Stocks.Add(st3);
                StockContext.Stocks.Add(st4);
                StockContext.Stocks.Add(st5);
                StockContext.Stocks.Add(st6);
                StockContext.Stocks.Add(st7);
                StockContext.Stocks.Add(st8);
                StockContext.Stocks.Add(st9);
                StockContext.Stocks.Add(st10);
                StockContext.Stocks.Add(st11);
                StockContext.Stocks.Add(st12);
                StockContext.Stocks.Add(st13);
                StockContext.Stocks.Add(st14);
                StockContext.Stocks.Add(st15);
                StockContext.Stocks.Add(st16);
                StockContext.Stocks.Add(st17);
                StockContext.Stocks.Add(st18);
                StockContext.Stocks.Add(st19);
                StockContext.Stocks.Add(st20);
                StockContext.Stocks.Add(st21);
                StockContext.Stocks.Add(st22);
                StockContext.Stocks.Add(st23);
                StockContext.Stocks.Add(st24);
                StockContext.Stocks.Add(st25);
                StockContext.Stocks.Add(st26);
                StockContext.SaveChanges();

            }
        }
    }
}
