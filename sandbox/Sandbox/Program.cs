


using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sandbox
{
    public class Car
    {
        public string model;
        public string brand;
        public int year;

        public void ShowCarDetails()
        {
           System.Console.WriteLine($"{brand} {model} {year}"); 
        }
    }

    public class Garage
    {
        public List<Car> Cars = new List<Car>(); 
    }
    class Program
    {
        static void Main()
        {
            System.Console.Clear();
            // var myCar = new Car();
            // myCar.brand = "BMW";
            // myCar.model = "CV7";
            // myCar.year = 2026;

            // myCar.ShowCarDetails();
 
            var myGarage = new Garage();

            while (true)
            {
                System.Console.WriteLine("Add cars to your garage (type done as brand to end)");
                
                Console.Write("Brand: ");
                string brand = Console.ReadLine();
                if (brand.ToLower() == "done")
                {
                    break;
                }

                Console.Write("Model: ");
                string model = Console.ReadLine();

                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());

                myGarage.Cars.Add(new Car{brand = brand, model = model, year = year});
            }
            Console.Write("\nCars in your garage: ");
            foreach (var car in myGarage.Cars)
            {
                car.ShowCarDetails();
            }

        }
    }

}