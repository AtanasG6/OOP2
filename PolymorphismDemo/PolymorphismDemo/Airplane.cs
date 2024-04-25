namespace PolymorphismDemo
{
	public class Airplane : Vehicle
	{
        public int MaxPeople { get; set; }

		public override string Drive()
		{
			return "Airplane is flying...";
		}

		public new string Stop()
		{
			return "Airplaine stopped moving";
		}
	}
}
