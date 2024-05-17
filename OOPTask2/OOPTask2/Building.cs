namespace OOPTask2
{
	public class Building : IBuilding
	{
		private readonly double _area;
		private readonly double _height;
		private readonly string _color;

        public Building(double area, double height, string color)
        {
            this.Area = area;
			this.Height = height;
			this.Color = color;
        }


        public double Area
		{
			get
			{
				return this._area;
			}
			protected init
			{
				if (value <= 0)
				{
					throw new ArgumentException("Invalid input!");
				}
				this._area = value;
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
					throw new ArgumentException("Invalid input!");
				}
				this._height = value;
			}
		}

		public string Color
		{
			get
			{
				return this._color;
			}
			private init
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Invalid input!");
				}
				this._color = value;
			}
		}

		public override string ToString()
		{
			return $"{this.GetType().Name}'s area is {this.Area}," +
				$" height is {this.Height}, color is {this.Color}.";
		}
	}
}
