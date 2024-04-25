namespace PolymorphismDemo
{
	public class Ship : Vehicle
	{
        public int MaxDepth { get; set; }

		public override string Drive()
		{
			return "Ship is floating...";
		}
	}
}
