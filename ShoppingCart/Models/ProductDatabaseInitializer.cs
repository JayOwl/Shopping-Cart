using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.Entity;

namespace ShoppingCart.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
 {
                    CategoryID = 1,
                    CategoryName = "Sports Gear"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "SkateBoards"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Travel Packs"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Snowboards"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Sleepwear"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
             {
                    ProductID = 107,
                    ProductName = "Bike Gloves",
                    Description = "These are the most comfortable Bike Gloves anyone has ever seen",
                    ImagePath="bikegloves.png",
                    UnitPrice = 14.99,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 218,
                    ProductName = "Hockey Stick",
                    Description = "You'll be able to shoot faster than Brett Hull with this stick",
                    ImagePath="hockeystick.png",
                    UnitPrice = 23.97,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 329,
                    ProductName = "Jersey",
                    Description = "This is a flame retardant Jersey.",
                    ImagePath="jersey.png",
                    UnitPrice = 56.32,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Race Wheel",
                    Description = "This will make your car go very fast if you want it to. ",
                    ImagePath="racewheel.png",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Jamie Thomas Skateboard",
                    Description = "The best skateboard design ever. ",
                    ImagePath="skateboard.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },

                new Product
                {
                    ProductID = 10,
                    ProductName = "Around the World in 80 Days",
                    Description = "Travel around the world in 80 days",
                    ImagePath="trip.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 86,
                    ProductName = "Gooose Down Sleeping Bag",
                    Description = "The best sleep you'll ever have, as long as you don't loose an eye",
                    ImagePath="gooseblanket.png",
                    UnitPrice = 15.00,
                    CategoryID = 5
                },


                new Product
                {
                    ProductID = 13,
                    ProductName = "Ross Rebagliati snowboard",
                    Description = "This board will make you soar high in the air really fast",
                    ImagePath="snowboard.png",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
            };

            return products;
        }
    }
}