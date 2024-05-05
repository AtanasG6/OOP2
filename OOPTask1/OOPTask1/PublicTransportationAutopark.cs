namespace OOPTask1
{
    public class PublicTransportationAutopark : Autopark
    {
        public int MaximumPassengers { get; }

        public PublicTransportationAutopark(List<MotorVehicle> vehicles)
            :base(vehicles) 
        {
            this.MaximumPassengers = this.Vehicles.Sum(v => v.MaximumPassengers);
        }

        public override string ToString()
        {
            return base.ToString() + $" Maximum passengers count is {this.MaximumPassengers}.";
        }
    }
}
