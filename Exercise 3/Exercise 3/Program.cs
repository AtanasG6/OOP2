using Exercise_3;
using System.Diagnostics;
using System.Xml.Linq;

class Program
{
    public static void Main()
    {
        var product1 = new Product(1, 10, DateTime.Now.AddDays(3), "Product1");
        var product2 = new Product(2, 12, DateTime.Now.AddDays(4), "Product2");

        var cart = new Cart();
        cart.Products.Add(product1);
        cart.Products.Add(product2);
        Console.WriteLine(cart.TotalSum());

        var store = new Store();
        store.AddAmount(product1, 12);
        var searchedProduct = store.Find("Product1");
        Console.WriteLine(searchedProduct.Quantity);

    }
}