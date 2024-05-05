namespace OOPTask1
{
    public class Autopark
    {
        private const string ERROR_MESSAGE = "Invalid input!";
        private readonly IReadOnlyCollection<MotorVehicle> _vehicles;


        public Autopark(List<MotorVehicle> vehicles)
        {
            this.Vehicles = vehicles;
        }

        public IReadOnlyCollection<MotorVehicle> Vehicles
		{
			get 
			{ 
				return this._vehicles; 
			}
			private init 
			{ 
				if (value is null)
				{
					throw new ArgumentException(ERROR_MESSAGE);
				}
                foreach (var vehicle in value)
                {
                    if (vehicle == null)
                    {
                        throw new ArgumentException(ERROR_MESSAGE);
                    }
                }
                this._vehicles = value;
			}
		}


        public override string ToString()
        {
            return $"{this.GetType().Name}'s vehicle count is {this.Vehicles.Count}.";
        }
    }
}
