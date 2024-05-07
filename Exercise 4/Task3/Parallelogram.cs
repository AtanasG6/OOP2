namespace Task3
{
	public class Parallelogram : Quadrilateral
	{
		private const string ERROR_MESSAGE = "Invalid input!";
		private double _sideA;
		private double _sideB;
		private double _heightA;


        public Parallelogram(double sideA, double sideB, double heightA)
        {
            this.SideA = sideA;
			this.SideB = sideB;
			this.HeightA = heightA;
        }

        public double SideA
		{
			get 
			{ 
				return this._sideA; 
			}
			private init 
			{ 
				if ( value <= 0 ) 
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

		public double HeightA
		{
			get
			{
				return this._heightA;
			}
			private init
			{
				if (value <= 0)
				{
					throw new ArgumentException(ERROR_MESSAGE);
				}
				this._heightA = value;
			}
		}

		public override double GetArea()
		{
			return this.HeightA * this.SideA;
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
