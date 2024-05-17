namespace OOPTask2
{
	public abstract class Room : IRoom
	{
		private readonly double _area;
		private readonly string _color;

        protected Room(double area, string color)
        {
			this.Area = area;
			this.Color = color;
        }

        public double Area
		{
			get 
			{ 
				return this._area; 
			}
			private init 
			{
				if (value <= 0)
				{
					throw new ArgumentException("Invalid input!");
				}
				this._area = value;
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
	}
}
