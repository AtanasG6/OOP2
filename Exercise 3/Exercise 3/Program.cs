using Exercise_3;

class Program
{
    public static void Main()
    {
        //var product1 = new Product(1, 10, DateTime.Now.AddDays(3), "Product1");
        //var product2 = new Product(2, 12, DateTime.Now.AddDays(4), "Product2");

        //var cart = new Cart();
        //cart.Products.Add(product1);
        //cart.Products.Add(product2);
        //Console.WriteLine(cart.TotalSum());

        //var store = new Store();
        //store.AddAmount(product1, 12);
        //var searchedProduct = store.Find("Product1");
        //Console.WriteLine(searchedProduct.Quantity);


        MyRectangle rect1 = new MyRectangle(new Point(3.3, 6.7), new Point(4.5, 9));
        
        Console.WriteLine("Perimeter: " + rect1.Perimeter);
        Console.WriteLine("Area " + rect1.Face);

    }
}