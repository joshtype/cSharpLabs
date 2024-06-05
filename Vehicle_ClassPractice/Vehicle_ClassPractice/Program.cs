// Joshua Gregory - June 2024
// Vehicle_ClassPractice - C# Class Practice
namespace Vehicle_ClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create & display Vehicle object
            Vehicle veh1 = new Vehicle("Unknown make/model", 1900);
            Console.WriteLine(veh1.ToString());

            // create & display Truck object
            Truck truck1 = new Truck("Ford F-150", 1990, 6.5, true);
            Console.WriteLine(truck1.ToString());

            // create & display Car object
            Car car1 = new Car("Chevy Camaro", 2001, 2, false);
            Console.WriteLine(car1.ToString());
        }
    }
}
