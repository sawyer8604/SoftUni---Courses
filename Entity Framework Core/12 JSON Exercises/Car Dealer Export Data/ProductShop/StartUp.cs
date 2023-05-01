using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.DataTransferObjects;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        static IMapper mapper;
        public static void Main(string[] args)
        {
            var productShopContext = new ProductShopContext();

            productShopContext.Database.EnsureDeleted();
            productShopContext.Database.EnsureCreated();


            string inputJsonUsers = File.ReadAllText("../../../Datasets/users.json");
            string inputJsonProducts = File.ReadAllText("../../../Datasets/products.json");
            string inputJsonCategoriess = File.ReadAllText("../../../Datasets/categories.json");
            string inputJsonCategoriessAndProducts = File.ReadAllText("../../../Datasets/categories-products.json");


            //01.Import Users
            var resultUsers = ImportUsers(productShopContext, inputJsonUsers);

           // 02.Import Products
           var resultProducts = ImportProducts(productShopContext, inputJsonProducts);

            //03.Import Categories
           var resultCategories = ImportCategories(productShopContext, inputJsonCategoriess);

            //04.Import Categories and Products

           var resultCategoriesAndProducts = ImportCategoryProducts(productShopContext, inputJsonCategoriessAndProducts);

            Console.WriteLine(GetUsersWithProducts(productShopContext));
        }

        private static void InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            });

            mapper = config.CreateMapper();
        }

        // 01. Import Users
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            InitializeAutoMapper();

            var dtoUsers = JsonConvert.DeserializeObject<IEnumerable<UserInputModel>>(inputJson);

            var users = mapper.Map<IEnumerable<User>>(dtoUsers);

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count()}";
        }


        //02. Import Products
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            InitializeAutoMapper();

            var dtoProducts = JsonConvert.DeserializeObject<IEnumerable<ProductInputModel>>(inputJson);

            var products = mapper.Map<IEnumerable<Product>>(dtoProducts);

            context.Products.AddRange(products);
            context.SaveChanges();


            return $"Successfully imported {products.Count()}";
        }

        // 03. Import Categories

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            InitializeAutoMapper();

            var dtoCategory = JsonConvert.DeserializeObject<IEnumerable<CategoryInputModel>>(inputJson)
                .Where(x => x.Name != null);

            var categories = mapper.Map<IEnumerable<Category>>(dtoCategory);

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Count()}";
        }


        // 04. Import Categories and Products

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            InitializeAutoMapper();

            var dtoCategoryProduct = JsonConvert.DeserializeObject<IEnumerable<CategoryAndProductInputModel>>(inputJson);

            var categoryProduct = mapper.Map<IEnumerable<CategoryProduct>>(dtoCategoryProduct);

            context.CategoryProducts.AddRange(categoryProduct);
            context.SaveChanges();

            return $"Successfully imported {categoryProduct.Count()}";
        }

        // Query 5. Export Products in Range
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p => new
                {
                    name = p.Name,
                    price = p.Price,
                    seller = p.Seller.FirstName + " " + p.Seller.LastName
                })
                .OrderBy(price => price.price)
                .ToArray();

            var result = JsonConvert.SerializeObject(products, Formatting.Indented);

            return result;
        }

        // 06. Export Sold Products

        public static string GetSoldProducts(ProductShopContext context)
        {
            var soldProducts = context.Users
                 .Where(u => u.ProductsSold.Any(p => p.BuyerId != null))
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    soldProducts = u.ProductsSold
                         .Select(p => new
                         {
                             name = p.Name,
                             price = p.Price,
                             buyerFirstName = p.Buyer.FirstName,
                             buyerLastName = p.Buyer.LastName,
                         })
                })
                .OrderBy(x => x.lastName)
                .ThenBy(x => x.firstName)
                .AsNoTracking()
                .ToArray();

            var result = JsonConvert.SerializeObject(soldProducts, Formatting.Indented);

            return result;

        }

        // 07. Export Categories By Products Count

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
               .Select(x => new
               {
                   category = x.Name,
                   productsCount = x.CategoryProducts.Count(),
                   averagePrice = Math.Round(x.CategoryProducts.Average(x => x.Product.Price), 2),
                   totalRevenue = Math.Round(x.CategoryProducts.Sum(x => x.Product.Price), 2)

               })
               .OrderByDescending(x => x.productsCount)
               .AsNoTracking()
               .ToArray();

            var result = JsonConvert.SerializeObject(categories, Formatting.Indented);

            return result;
        }


        // 08. Export Users and Products

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
            .Where(u => u.ProductsSold.Any(p => p.BuyerId != null))
            .OrderByDescending(u => u.ProductsSold.Count(p => p.BuyerId != null))
            .Select(u => new
            {
                firstName = u.FirstName,
                lastName = u.LastName,
                age = u.Age,
                soldProducts = new
                {
                    count = u.ProductsSold
                            .Count(p => p.BuyerId != null),
                    products = u.ProductsSold
                            .Where(p => p.BuyerId != null)
                            .Select(p => new
                            {
                                name = p.Name,
                                price = p.Price
                            })
                }
            })
            .AsNoTracking()
            .ToArray();

            var info = new
            {
                usersCount = users.Count(),
                users = users
            };

            string result = JsonConvert.SerializeObject(info, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            return result;
        }

    }
}