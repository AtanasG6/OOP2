namespace OOPTask1
{
    public class PublicTransportationAutopark : Autopark
    {
        public int MaximumPassengers
            => this.Vehicles.Sum(v => v.MaximumPassengers);
        

        public PublicTransportationAutopark(List<MotorVehicle> vehicles)
            :base(vehicles) 
        {
        }

        public override string ToString()
        {
            return base.ToString() + $" Maximum passengers count is {this.MaximumPassengers}.";
        }
    }
}
