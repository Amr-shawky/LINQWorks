using ProjectionAndFiltering;

namespace SetOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set Operations in LINQ
            // What are set operations?
            // Set Operations: Methods that perform operations on collections like union, intersection, and difference
            // Distinct, DistinctBy, Except, ExceptBy, Intersect, IntersectBy, Union, UnionBy

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Set Operations examples:");

            var products1 = new List<Product>
            {
                new Product { Id = 1, Name = "Product A", Price = 100 },
                new Product { Id = 2, Name = "Product B", Price = 200 },
                new Product { Id = 3, Name = "Product C", Price = 300 }
            };

            var products2 = new List<Product>
            {
                new Product { Id = 3, Name = "Product C", Price = 300 },
                new Product { Id = 4, Name = "Product D", Price = 400 },
                new Product { Id = 5, Name = "Product E", Price = 500 }
            };

            // UnionBy: Combine two lists based on Id, removing duplicates
            Console.WriteLine("\nUnionBy Id:");
            var unionProducts = products1.UnionBy(products2, p => p.Id);
            foreach (var product in unionProducts)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            // IntersectBy: Find common products by Id
            Console.WriteLine("\nIntersectBy Id:");
            var commonProducts = products1.IntersectBy(products2.Select(p => p.Id), p => p.Id);
            foreach (var product in commonProducts)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            // ExceptBy: Find products in products1 that are not in products2 by Id
            Console.WriteLine("\nExceptBy Id:");
            var uniqueProducts1 = products1.ExceptBy(products2.Select(p => p.Id), p => p.Id);
            foreach (var product in uniqueProducts1)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            // DistinctBy: Remove duplicates from a combined list based on Name
            Console.WriteLine("\nDistinctBy Name (from combined lists):");
            var allProducts = products1.Concat(products2);
            var distinctByName = allProducts.DistinctBy(p => p.Name);
            foreach (var product in distinctByName)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
