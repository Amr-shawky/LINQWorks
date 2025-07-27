using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinsAndGrouping
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Joins and Grouping in LINQ
            // - Joins: Join, GroupJoin
            // - Grouping: GroupBy, ToLookup

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Joins and Grouping in LINQ:");

            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Clothing" },
                new Category { Id = 3, Name = "Books" }
            };

            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", CategoryId = 1 },
                new Product { Id = 2, Name = "Smartphone", CategoryId = 1 },
                new Product { Id = 3, Name = "T-Shirt", CategoryId = 2 },
                new Product { Id = 4, Name = "Novel", CategoryId = 3 },
                new Product { Id = 5, Name = "Jeans", CategoryId = 2 }
            };

            // 1. Join (Inner Join)
            Console.WriteLine("\nJoin (Products with Category Names):");
            var productWithCategories = products.Join(
                categories,
                product => product.CategoryId,
                category => category.Id,
                (product, category) => new
                {
                    ProductName = product.Name,
                    CategoryName = category.Name
                });

            foreach (var item in productWithCategories)
            {
                Console.WriteLine($"Product: {item.ProductName}, Category: {item.CategoryName}");
            }

            // 2. GroupJoin (Left Join)
            Console.WriteLine("\nGroupJoin (Categories with Products):");
            var categoriesWithProducts = categories.GroupJoin(
                products,
                category => category.Id,
                product => product.CategoryId,
                (category, prods) => new
                {
                    CategoryName = category.Name,
                    Products = prods
                });

            foreach (var group in categoriesWithProducts)
            {
                Console.WriteLine($"Category: {group.CategoryName}");
                foreach (var product in group.Products)
                {
                    Console.WriteLine($" - Product: {product.Name}");
                }
            }

            // 3. GroupBy
            Console.WriteLine("\nGroupBy (Products grouped by CategoryId):");
            var groupedProducts = products.GroupBy(p => p.CategoryId);
            foreach (var group in groupedProducts)
            {
                Console.WriteLine($"CategoryId: {group.Key}");
                foreach (var product in group)
                {
                    Console.WriteLine($" - {product.Name}");
                }
            }

            // 4. ToLookup (like GroupBy, but immediate execution and lookup-based)
            Console.WriteLine("\nToLookup (Products lookup by CategoryId):");
            var lookup = products.ToLookup(p => p.CategoryId);
            foreach (var group in lookup)
            {
                Console.WriteLine($"CategoryId: {group.Key}");
                foreach (var product in group)
                {
                    Console.WriteLine($" - {product.Name}");
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
