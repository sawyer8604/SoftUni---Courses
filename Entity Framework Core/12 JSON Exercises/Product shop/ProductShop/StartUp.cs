using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using AutoMapper;
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


            // 01. Import Users
            var resultUsers = ImportUsers(productShopContext, inputJsonUsers);

            // 02. Import Products
            var resultProducts = ImportProducts(productShopContext, inputJsonProducts);

            // 03. Import Categories
            var resultCategories = ImportCategories(productShopContext, inputJsonCategoriess);

            // 04. Import Categories and Products

            var resultCategoriesAndProducts = ImportCategoryProducts(productShopContext, inputJsonCategoriessAndProducts);

            Console.WriteLine(resultCategoriesAndProducts);
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
    }
}