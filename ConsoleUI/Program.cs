using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("-- GetAll Function Call: \n");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " "+car.ModelYear );
            }

            Console.WriteLine("\n-- Add Function Call: \n");
            carManager.Add(new Car { CarId = 6, BrandId = 3, ColorId = 3, ModelYear = "2018", DailyPrice = 80, Description = "Renault" });
            carManager.Add(new Car { CarId = 7, BrandId = 4, ColorId = 4, ModelYear = "2017", DailyPrice = 70, Description = "Alfa Romeo" });


            Console.WriteLine("\n-- GetById Function Call: \n");
            Car _car =carManager.GetById(2);
            Console.WriteLine("Car id= " + _car.CarId + ": " + _car.Description);

            Console.WriteLine("\n-- Update And Function Calls: \n");

            carManager.Update(_car);
            carManager.Delete(_car);

            foreach (var c in carManager.GetAll()) // to see the changes
            {
                Console.WriteLine(c.CarId + " " + c.Description);
            }



        }
    }
}
