namespace ProjectionAndFiltering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // projection and filtering
            // what is projection and filtering?
            // Projection: Selecting specific fields from a data source
            // Filtering: Selecting records based on certain criteria
            // Example: Using LINQ to project and filter a list of products by a syntax method
            // select, where, OfType.
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 100 },
                new Product { Id = 2, Name = "Product 2", Price = 200 },
                new Product { Id = 3, Name = "Product 3", Price = 300 },
                new viproduct { Id = 4, Name = "Product 4", Price = 150 },
                new viproduct { Id = 5, Name = "Product 5", Price = 250 }
            };

            // Projecting product names
            var productNames = products.Select(p => p.Name);

            Console.WriteLine("Product Names:");

            foreach (var name in productNames)
            {
                Console.WriteLine(name);
            }
            // Filtering products with price greater than 150
            var filteredProducts = products.Where(p => p.Price > 150);

            Console.WriteLine("Filtered Products (Price > 150):");

            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            // Using OfType to filter products of a specific type (if applicable)
            var vipProducts = products.OfType<viproduct>();

            Console.WriteLine("VIP Products:");
            foreach (var vip in vipProducts)
            {
                Console.WriteLine($"Id: {vip.Id}, Name: {vip.Name}, Price: {vip.Price}");
            }
            // example using query syntax
            var query = from p in products
                        where p.Price > 150
                        select p;

            var query2 = from x in products
                         where x.Price < 200
                         select x.Name;

            Console.WriteLine("Filtered Products (Price > 150) - Query Syntax:");
            foreach (var product in query)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine("Filtered Products (Price < 200) - Query Syntax:");
            foreach (var product in query2)
            {
                Console.WriteLine(product);
            }

        }
    }
}
