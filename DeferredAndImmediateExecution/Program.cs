using ProjectionAndFiltering;

public class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Deferred execution example:");

        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 100 },
            new Product { Id = 2, Name = "Product 2", Price = 200 },
            new Product { Id = 3, Name = "Product 3", Price = 300 }
        };

        // Deferred execution query
        var deferredQuery = products.Where(p => p.Price > 200);

        // Modify the original data before enumeration

        Console.ForegroundColor = ConsoleColor.White;
        //data before filtering
        Console.WriteLine("Products before adding:");
        foreach (var product in deferredQuery)
        {
            Console.WriteLine($"- {product.Name}: {product.Price}");
        }
        products.Add(new Product { Id = 4, Name = "Product 4", Price = 400 });
        Console.WriteLine("Deferred query results (after adding new item product 4):");
        foreach (var product in deferredQuery)
        {
            Console.WriteLine($"- {product.Name}: {product.Price}");
        }

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\nImmediate execution example:");

        // Immediate execution
        var immediateQuery = products.Where(p => p.Price > 200).ToList();

        // Modify the original data after immediate execution
        products.Add(new Product { Id = 5, Name = "Product 5", Price = 500 });

        Console.ForegroundColor = ConsoleColor.White;
        //data before filtering
        Console.WriteLine("data before adding:");
        foreach (var product in immediateQuery)
        {
            Console.WriteLine($"- {product.Name}: {product.Price}");
        }
        Console.WriteLine("Immediate query results (should NOT include Product 5):");
        foreach (var product in immediateQuery)
        {
            Console.WriteLine($"- {product.Name}: {product.Price}");
        }

        Console.ResetColor();
    }
}
