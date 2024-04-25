namespace PolymorphismDemo
{
	public abstract class Vehicle : IVehicle
	{
        public string Model { get; set; }

		public virtual string Drive()
		{
			return "Vehicle is moving...";
		}

		public string Stop() 
		{
			return "Vehicle stopped moving...";
		}
	}
}
