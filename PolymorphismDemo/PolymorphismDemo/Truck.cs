namespace PolymorphismDemo
{
	public class Truck : Vehicle
	{
        public int MaxLoad { get; set; }

		public new string Stop()
		{
			return "Truck stopped moving...";
		}
    }
}
