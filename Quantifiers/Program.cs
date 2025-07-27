using ProjectionAndFiltering;

namespace Quantifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Quantifiers in LINQ
            // What are quantifiers?
            // Quantifiers: Methods that check if any or all elements in a collection meet a condition
            // Example: Using LINQ to check if any product is expensive or if all products are affordable
            //All, Any, Contains
            Console.ForegroundColor = ConsoleColor.Green;
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 100 },
                new Product { Id = 2, Name = "Product 2", Price = 200 },
                new Product { Id = 3, Name = "Product 3", Price = 300 },
                new Product { Id = 4, Name = "Product 4", Price = 150 },
                new Product { Id = 5, Name = "Product 5", Price = 250 }
            };
            // Check if any product is expensive (price > 250)
            bool anyExpensiveProducts = products.Any(p => p.Price > 250);
            Console.WriteLine($"Any expensive products: {anyExpensiveProducts}");
            // Check if all products are affordable (price < 400)
            bool allAffordableProducts = products.All(p => p.Price < 400);
            Console.WriteLine($"All products are affordable: {allAffordableProducts}");
            // Check if a specific product exists in the list
            bool containsProduct = products.Contains(new Product { Id = 1, Name = "Product 1", Price = 100 });
            Console.WriteLine($"Contains Product 1: {containsProduct}");
            // Example using query syntax
            Console.ForegroundColor = ConsoleColor.Blue;
            var queryAnyExpensive = from p in products
                                    where p.Price > 250
                                    select p;
            bool anyExpensiveQuerySyntax = queryAnyExpensive.Any();
            Console.WriteLine($"Any expensive products (query syntax): {anyExpensiveQuerySyntax}");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
