using ProjectionAndFiltering;

namespace Partitioning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Partitioning in LINQ
            // What is partitioning?
            // Partitioning: Dividing a collection into smaller segments or groups
            // use of Take, Skip, TakeWhile, SkipWhile , chunk
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Partitioning examples:");
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 100 },
                new Product { Id = 2, Name = "Product 2", Price = 200 },
                new Product { Id = 3, Name = "Product 3", Price = 300 },
                new Product { Id = 4, Name = "Product 4", Price = 150 },
                new Product { Id = 5, Name = "Product 5", Price = 250 }
            };
            // Take first 3 products
            var firstThreeProducts = products.Take(3);
            Console.WriteLine("First 3 Products:");
            foreach (var product in firstThreeProducts)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            // skip first 2 products
            Console.WriteLine("Skipping first 2 Products:");
            var skippedProducts = products.Skip(2);
            foreach (var product in skippedProducts)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            // TakeWhile: Take products while the price is less than 250
            Console.WriteLine("Taking products while price is less than 250:");
            var productsUnder250 = products.TakeWhile(p => p.Price < 250);
            foreach (var product in productsUnder250)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            // SkipWhile: Skip products while the price is less than 200
            Console.WriteLine("Skipping products while price is less than 200:");
            var productsAfter200 = products.SkipWhile(p => p.Price < 200);
            foreach (var product in productsAfter200)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            // Chunk: Divide products into chunks of 2
            Console.WriteLine("Chunking products into groups of 2:");
            var productChunks = products.Chunk(2);
            foreach (var chunk in productChunks)
            {
                Console.WriteLine("Chunk:");
                foreach (var product in chunk)
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
