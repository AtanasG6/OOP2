namespace OOPTask1
{
    public class Program
    {
        static void Main()
        {
            Car car = new Car(120, 5, 50);
            Van van = new Van(140, 7, 60);
            Bus bus = new Bus(90, 12, 70);

            var list1 = new List<MotorVehicle>() { car, van };
            var list2 = new List<MotorVehicle>() { van, van, bus };

            //Autopark[] parks = { new Autopark(list1), new PublicTransportationAutopark(list2)};
            //Console.ForegroundColor = ConsoleColor.Green;
            //foreach (var park in parks)
            //{
            //    Console.WriteLine(park);
            //}
            var park1 = new PublicTransportationAutopark(list1);
            Console.WriteLine(park1);
            var park2 = new PublicTransportationAutopark(list2);
            Console.WriteLine(park1);
            Console.WriteLine(park2);
        }
    }
}
