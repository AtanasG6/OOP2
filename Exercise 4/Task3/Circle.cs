namespace Task3
{
	public class Circle : Shape
	{
		private const string ERROR_MESSAGE = "Invalid input!";
		private double _radius;

		public Circle(double radius)
		{
			this.Radius = radius;
		}

		public double Radius
		{
			get
			{
				return this._radius;
			}
			private init
			{
				if (value <= 0)
				{
					throw new ArgumentException(ERROR_MESSAGE);
				}
				this._radius = value;
			}
		}

		public override double GetArea()
		{
			return Math.PI * Math.Pow(this.Radius, 2);
		}

		public override double GetPerimeter()
		{
			return 2 * Math.PI * this.Radius;
		}

		public override string WhoAmI()
		{
			return $"I am of type {this.GetType().Name}.";
		}
	}
}
