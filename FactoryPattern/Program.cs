namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the number of wheels you would like");

            string userInput = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(userInput);

            Console.WriteLine();
            vehicle.Drive();
        }
    }
}
