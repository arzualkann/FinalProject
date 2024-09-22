public class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public short UnitInStock { get; set; }
    public decimal UnitPrice { get; set; }
}

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Category> categories = new List<Category> {
        new Category{CategoryId=1,CategoryName="Bilgisayar" },
        new Category{CategoryId=2,CategoryName="Telefon" },
        };

        List<Product> products = new List<Product>
        {
            new Product{ ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 gb",UnitPrice=10000,UnitInStock=5},
            new Product{ ProductId=1,CategoryId=1,ProductName="asus Laptop",QuantityPerUnit="16 gb",UnitPrice=8000,UnitInStock=3},
            new Product{ ProductId=1,CategoryId=1,ProductName="hp Laptop",QuantityPerUnit="8 gb",UnitPrice=6000,UnitInStock=2},
            new Product{ ProductId=1,CategoryId=2,ProductName="samsung",QuantityPerUnit="4 gb",UnitPrice=5000,UnitInStock=15},
            new Product{ ProductId=1,CategoryId=2,ProductName="apple",QuantityPerUnit="4 gb",UnitPrice=8000,UnitInStock=0},
        };

        foreach (var product in products)
        {
            if (product.UnitPrice>5000)
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
        Console.WriteLine("------------linqq-----------");
        var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);

        foreach (var product in result)
        {
            
            Console.WriteLine(product.ProductName);
        }
        

    }
}