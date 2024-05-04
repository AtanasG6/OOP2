namespace OOPTask1
{
    public class PublicTransportationAutopark : Autopark
    {
        public int MaximumPassengers
        {
            get 
            {
                return CalculatePassengers();
            }
        }

        public PublicTransportationAutopark(List<MotorVehicle> vehicles)
            :base(vehicles) 
        {
        }


        private int CalculatePassengers()
        {
            int result = 0;
            foreach (var vehicle in Vehicles)
            {
                if (vehicle is not null)
                {
                    result += vehicle.MaximumPassengers;
                }
            }
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + $" Maximum passengers count is {this.MaximumPassengers}.";
        }
    }
}
