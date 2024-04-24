namespace Exercise_3
{
    public class Product
    {
		private int _quantity;

		public int Quantity
		{
			get { return _quantity; }
			set 
			{ 
				if (value > 0)
				{
					_quantity = value;
				}
				else
				{
					throw new InvalidOperationException("Quantity must be greater than 0.");
				}
			}
		}


		private double _price;

		public double Price
		{
			get { return _price; }
			set 
			{ 
				if (value > 0)
				{
                    _price = value;
                }
				else
				{
					throw new ArgumentOutOfRangeException("Price must be greater than 0!");
				}
				
			}
		}

		private DateTime _expireDate;

		public DateTime ExpireDate
        {
			get { return _expireDate; }
			set 
			{
				if (value < DateTime.Now)
				{
                    _expireDate = value;
                }
				else
				{
					throw new ArgumentOutOfRangeException("The expire date must be in the future!");
				}		
			}
		}

		private string name;

		public string Name
		{
			get { return name; }
			set 
			{
				if (value.Length < 3)
				{
					name = value;	
				}
				else
				{
					throw new ArgumentOutOfRangeException("Name must be longer than 3 characters!");
				}
			}
		}

        public Product()
        {
			
        }

        public Product(int quantity, double price, DateTime expireDate, string name)
        {
			Quantity = quantity;
			Price = price;
			ExpireDate = expireDate;
			Name = name;
        }

    }
}
