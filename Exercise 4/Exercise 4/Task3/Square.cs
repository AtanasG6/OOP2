namespace Task3
{
	public class Square : Quadrilateral
	{
		private const string ERROR_MESSAGE = "Invalid input!";
		private double _side;

        public Square(double side)
        {
            this.Side = side;
        }

        public double Side
		{
			get 
			{ 
				return _side; 
			}
			private init 
			{
				if (value<=0)
				{
					throw new ArgumentException(ERROR_MESSAGE);
				}
				this._side = value;
			}
		}

        public override double GetArea()
		{
			return Math.Pow(this.Side, 2);
		}

		public override double GetPerimeter()
		{
			return 4 * this.Side;
		}

		public override string WhoAmI()
		{
			return $"I am of type {this.GetType().Name}.";
		}
	}
}
