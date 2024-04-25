namespace PolymorphismDemo
{
	public class AirFighter : Airplane
	{
        public int Damage { get; set; }

		public override string Drive()
		{
			return "Airfighter is fighting...";
		}
	}
}
