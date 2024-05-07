namespace Task3
{
	public class IsoscelesTriangle : Triangle
	{
		private const string ERROR_MESSAGE = "Invalid input!";
		private double _side;
		private double _angle;

        public IsoscelesTriangle(double side, double angle)
        {
            this.Side = side;
		    this.Angle = angle;
        }

        public double Side
		{
			get
			{
				return _side;
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

		public double Angle
		{
			get
			{
				return _angle;
			}
			private init
			{
				if (value <= 0 || value >= Math.PI)
				{
					throw new ArgumentException(ERROR_MESSAGE);
				}
				this._angle = value;
			}
		}



		public override double GetArea()
		{
			return 0.5 * Math.Pow(this.Side, 2) * Math.Sin(this.Angle);
		}

		private double CalculateThirdSide()
		{
			double thirdSide = Math.Sqrt(Math.Pow(this.Side, 2) + Math.Pow(this.Side, 2) - 2 * this.Side * this.Side * Math.Cos(this.Angle));

			return thirdSide;
		}

		public override double GetPerimeter()
		{
			return this.CalculateThirdSide() + 2 * this.Side;
		}

		public override string WhoAmI()
		{
			return $"I am of type {this.GetType().Name}.";
		}
	}
}
