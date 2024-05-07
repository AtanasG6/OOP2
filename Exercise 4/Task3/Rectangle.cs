namespace Task3
{
	public class Rectangle : Quadrilateral
	{
		private const string ERROR_MESSAGE = "Invalid input!";
		private double _sideA;
		private double _sideB;

		public Rectangle(double sideA, double sideB)
		{
			this.SideA = sideA;
			this.SideB = sideB;
		}

		public double SideA
		{
			get
			{
				return this._sideA;
			}
			private init
			{
				if (value <= 0)
				{
					throw new ArgumentException(ERROR_MESSAGE);
				}
				this._sideA = value;
			}
		}

		public double SideB
		{
			get
			{
				return this._sideB;
			}
			private init
			{
				if (value <= 0)
				{
					throw new ArgumentException(ERROR_MESSAGE);
				}
				this._sideB = value;
			}
		}

		public override double GetArea()
		{
			return this.SideA * this.SideB;
		}

		public override double GetPerimeter()
		{
			return 2 * (this.SideA + this.SideB);
		}

		public override string WhoAmI()
		{
			return $"I am of type {this.GetType().Name}.";
		}
	}
}
