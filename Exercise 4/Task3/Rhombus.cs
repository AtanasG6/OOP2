namespace Task3
{
	public class Rhombus : Quadrilateral
	{
		private const string ERROR_MESSAGE = "Invalid input!";
		private double _side;
		private double _height;


		public Rhombus(double side, double height)
		{
			this.Side = side;
			this.Height = height;
		}

		public double Side
		{
			get
			{
				return this._side;
			}
			private init
			{
				if (value <= 0)
				{
					throw new ArgumentException(ERROR_MESSAGE);
				}
				this._side = value;
			}
		}

		public double Height
		{
			get
			{
				return this._height;
			}
			private init
			{
				if (value <= 0)
				{
					throw new ArgumentException(ERROR_MESSAGE);
				}
				this._height = value;
			}
		}

		public override double GetArea()
		{
			return this.Height * this.Side;
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
