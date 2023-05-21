namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vehicle = new Car();

            vehicle.Year = 2013;
            vehicle.Make = "Toyota";
            vehicle.Model = "Corolla";

            vehicle.MyCar();
        }
    }
}
