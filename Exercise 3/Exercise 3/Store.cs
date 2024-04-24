using System.Linq;

namespace Exercise_3
{
    public class Store
    {
        public List<Product> Products { get; set; }

        public void Add(Product product)
        {
            Products.Add(product);
            product.Quantity++;
        }

        public void Remove(Product product)
        {
            if (Products.Contains(product))
            {
                Products.Remove(product);
            }
            else
            {
                throw new InvalidOperationException("There is no such product in the store.");
            }
        }

        public Product Find(string name)
        {
            return Products.FirstOrDefault(x => x.Name == name);
        }


        public void AddAmount(Product product, int quantity)
        {
            if (Products.Contains(product))
            {
                product.Quantity += quantity;
            }
        }

        public void SubtractAmount(Product product, int quantity)
        {
            if (Products.Contains(product) && product.Quantity >= quantity)
            {
                product.Quantity -= quantity;
            }
        }

        public Store()
        {
           Products = new List<Product>();
        }
    }
}
