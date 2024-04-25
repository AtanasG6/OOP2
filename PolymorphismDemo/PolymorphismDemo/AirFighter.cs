namespace PolymorphismDemo
{
	public class AirFighter : Airplane
	{
        public int Damage { get; set; }

		public override string Drive()
		{
			return "Airfighter is fighting...";
		}

		public string ShootARacket()
		{
            return "Shooting a racket...";
        }
	}
}
