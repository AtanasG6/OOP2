namespace OOPTask1
{
	public class LogisticsAutopark : Autopark
	{
			public double MaximumCargoWeight { get; }

			public LogisticsAutopark(List<MotorVehicle> vehicles)
				: base(vehicles)
			{
				this.MaximumCargoWeight = this.Vehicles.Sum(v => v.MaximumCargoWeight);
			}

			public override string ToString()
			{
				return base.ToString() + $" Maximum cargo weight is {this.MaximumCargoWeight}.";
			}
	
	}
}
