namespace OOPTask1
{
    public abstract class MotorVehicle
    {
		private const string ERROR_MESSAGE = "Invalid input!";
		private readonly double _power;
		private readonly int _maximumPassengers;
		private readonly double _maximumCargoWeight;


        protected MotorVehicle(double power, int maximumPassengers, double maximumCargoWeight)
        {
            this.Power = power;
            this.MaximumPassengers = maximumPassengers;
            this.MaximumCargoWeight = maximumCargoWeight;
            
        }


        public double Power
		{
			get 
			{ 
				return this._power; 
			}
			private init 
			{ 
				if (value <= 0)
				{
					throw new ArgumentException(ERROR_MESSAGE);
				}
				this._power = value; 
			}
		}

        public int MaximumPassengers
        {
            get
            {
                return this._maximumPassengers;
            }
            private init
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }
                this._maximumPassengers = value;
            }
        }


        public double MaximumCargoWeight
        {
            get 
            { 
                return this._maximumCargoWeight; 
            }
            private init
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }
                this._maximumCargoWeight = value;
            }
        }

    }
}
