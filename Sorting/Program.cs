using ProjectionAndFiltering;
namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            // what is the sorting?
            // Sorting: Arranging data in a specific order (ascending or descending)
            // OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse
            // Example: Using LINQ to sort a list of products by price
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 100 },
                new Product { Id = 2, Name = "Product 2", Price = 200 },
                new Product { Id = 3, Name = "Product 3", Price = 300 },
                new Product { Id = 4, Name = "Product 4", Price = 150 },
                new Product { Id = 5, Name = "Product 5", Price = 250 }
            };
            // make all the method syntax foreground green and the query syntax background blue
            Console.ForegroundColor = ConsoleColor.Green;
            // Sorting products by price
            var sortedProducts = products.OrderBy(p => p.Price);
            
            Console.WriteLine("Sorted Products (by Price):");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            // sorting product by price orderbydescending
            Console.WriteLine("Sorted Products (by Price Descending):");
            var sortedProductsDescending = products.OrderByDescending(p => p.Price);
            foreach (var product in sortedProductsDescending)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            // sorting product by multiple fields usng ThenBy and ThenByDescending
            Console.WriteLine("Sorted Products (by Price, then by Name):");
            var sortedProductsByPriceThenName = products
                .OrderBy(p => p.Price)
                .ThenBy(p => p.Name);
            foreach (var product in sortedProductsByPriceThenName)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine("Sorted Products (by Price Descending, then by Name Descending):");
            var sortedProductsByPriceDescendingThenNameDescending = products
                .OrderByDescending(p => p.Price)
                .ThenByDescending(p => p.Name);
            foreach (var product in sortedProductsByPriceDescendingThenNameDescending)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            // by query syntax
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sorted Products (by Price) - Query Syntax:");
            var query = from p in products
                        orderby p.Price
                        select p;
            foreach (var product in query)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine("Sorted Products (by Price Descending) - Query Syntax:");
            var queryDescending = from p in products
                                  orderby p.Price descending
                                  select p;
            foreach (var product in queryDescending)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            // sorting multiple fields using query syntax
            Console.WriteLine("Sorted Products (by Price, then by Name) - Query Syntax:");
            var queryByPriceThenName = from p in products
                                       orderby p.Price, p.Name
                                       select p;
            foreach (var product in queryByPriceThenName)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine("Sorted Products (by Price Descending, then by Name Descending) - Query Syntax:");
            var queryByPriceDescendingThenNameDescending = from p in products
                                                           orderby p.Price descending, p.Name descending
                                                           select p;
            foreach (var product in queryByPriceDescendingThenNameDescending)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
