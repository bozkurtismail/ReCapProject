using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ColorTest();
            //BrandTest();
            //CarTest();
            CarDetailTest();
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new UserValidationManager());
            Console.WriteLine("******************************************");
            Console.WriteLine("ARAÇ İSİMLERİ LISTELENDI");
            foreach (var carDetail in carManager.GetCarDetail())
            {
                Console.WriteLine(carDetail.CarId + "-" + carDetail.BrandName + "-" + carDetail.ColorName + "-" + carDetail.DailyPrice);
            }
        }

        private static void CarTest()
        {
            Console.WriteLine("***************************************\n");
            CarManager carManager = new CarManager(new EfCarDal(), new UserValidationManager());
            Console.WriteLine("\n-- Add Function Call: \n");
            carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelYear = "2001", DailyPrice = 3, Description = "GeriDönüşüm" });
            carManager.Add(new Car { BrandId = 2, ColorId = 2, ModelYear = "2002", DailyPrice = 5, Description = "GeriDönüşüm" });

            Console.WriteLine("***************************************\n");

            Console.WriteLine("--Car GetAll Function Call: \n");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " " + car.ModelYear);
            }

            Console.WriteLine("***************************************\n");
            Console.WriteLine("\n--Car GetByBrandId Function Call: \n");
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("***************************************\n");
            Console.WriteLine("\n--Car GetByColorId Function Call: \n");
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("***************************************\n");
            Console.WriteLine("--Car DELETE: \n");
            carManager.Delete(new Car { CarId = 2004 });
            carManager.Delete(new Car { CarId = 2005 });

            Console.WriteLine("***************************************\n");
            Console.WriteLine("--Brand UPDATE: \n");
            carManager.Update(new Car { CarId = 1,BrandId=3,ColorId=3,ModelYear="2018",DailyPrice=30,Description = "Geri Dönüşüm" });
            carManager.Update(new Car { CarId = 2,BrandId=3,ColorId=3,ModelYear="2017",DailyPrice=25,Description = "Geri Dönüşüm" });
        }

        private static void BrandTest()
        {
            Console.WriteLine("***************************************\n");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine("--Brand ADD: \n");
            brandManager.Add(new Brand { BrandName = "Toyota" });
            brandManager.Add(new Brand { BrandName = "Skoda" });
            Console.WriteLine("Add Success");

            Console.WriteLine("***************************************\n");
            Console.WriteLine("--Brand GetAll Function Call: \n");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("***************************************\n");

            Console.WriteLine("--Brand DELETE: \n");
            brandManager.Delete(new Brand { BrandId = 1002, BrandName = "Kia" });
            brandManager.Delete(new Brand { BrandId = 1003, BrandName = "Audi" });

            Console.WriteLine("***************************************\n");
            Console.WriteLine("--Brand UPDATE: \n");
            brandManager.Update(new Brand { BrandId = 3, BrandName = "Fiat" });
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine("--Color ADD: \n");
            colorManager.Add(new Color { ColorName = "Mor" });
            colorManager.Add(new Color { ColorName = "Pembe" });
            Console.WriteLine("Add Success");

            Console.WriteLine("***************************************\n");

            Console.WriteLine("--Color GetAll Function Call: \n");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine("***************************************\n");

            Console.WriteLine("--Color DELETE: \n");
            colorManager.Delete(new Color { ColorId = 1002, ColorName = "Sari" });
            colorManager.Delete(new Color { ColorId = 1003, ColorName = "Yeşil" });

            Console.WriteLine("***************************************\n");
            Console.WriteLine("--Color UPDATE: \n");
            colorManager.Update(new Color { ColorId = 1, ColorName = "Ak" });
        }
    }
}
