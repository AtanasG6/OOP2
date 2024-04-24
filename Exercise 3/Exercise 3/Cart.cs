namespace Exercise_3
{
    public class Cart
    {
        public List<Product> Products { get; private set; }

        public void AddProduct(Product product, int quantity)
        {
            if (!Products.Contains(product))
            {
                Products.Add(product);
            }
            product.Quantity += quantity;
        }

        public void RemoveProduct(Product product, int quantity)
        {
            if (Products.Contains(product) && product.Quantity >= quantity)
            {
                product.Quantity -= quantity;
            }
        }

        public double TotalSum()
        {
            double sum = 0;
            foreach (var product in Products)
            {
                sum += product.Price * product.Quantity;
            }

            return sum;
        }

        public Cart()
        {
             Products = new List<Product>();
        }
    }
}
