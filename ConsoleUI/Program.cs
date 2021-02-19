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
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //BrandIdTest(carManager, brandManager, colorManager);

            //ColorIdTest(carManager, brandManager, colorManager);

            //CarIdTest(carManager, brandManager, colorManager);

            //DailyPriceTest(carManager, brandManager, colorManager);

            //Console.WriteLine("\n");
            //AddTest(carManager, brandManager, colorManager);

            //DeleteTest(carManager, brandManager, colorManager);

            //CarDetails(carManager);
            
            ListCarsTest(carManager, brandManager, colorManager);
            
        }

        private static void DeleteTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            carManager.Delete(new Car { CarId = 1009 });

            var result = carManager.GetAll();

            if (result.Success)
            {            
                Console.WriteLine("Bütün arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescription");

                foreach (var car in result.Data )
                {
                    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void AddTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            carManager.Add(new Car { BrandId = 2, ColorId = 1, ModelYear = "2015", DailyPrice = 200, Description = "Megane" });
            brandManager.Add(new Brand { BrandName = "Siyah" });

            var result = carManager.GetAll();

            if (result.Success)
            {            
                Console.WriteLine("Bütün arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescription");

                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void DailyPriceTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            var result = carManager.GetByDailyPrice(100, 165);
            if (result.Success)
            {            
                Console.WriteLine("\n\nGünlük fiyat aralığı 100 ile 165 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");

                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void CarIdTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine("\n\nId'si 2 olan araba: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescription");
            Car carById = carManager.GetById(2).Data;
            Console.WriteLine($"{carById.CarId}\t{colorManager.GetById(carById.ColorId).ColorName}\t\t{brandManager.GetById(carById.BrandId).BrandName}\t\t{carById.ModelYear}\t\t{carById.DailyPrice}\t\t{carById.Description}");
        }

        private static void ColorIdTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            var result = carManager.GetAllByColorId(2);
            if (result.Success)
            {            
                Console.WriteLine("\n\nColor Id'si 2 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescription");

                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void BrandIdTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            var result = carManager.GetAllByBrandId(1);

            if (result.Success)
            {            
                Console.WriteLine("Brand Id'si 1 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescription");

                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }

        private static void ListCarsTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {

            var result = carManager.GetAll();
            if (result.Success)
            {
                Console.WriteLine("Bütün arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescription");
                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
        private static void CarDetails(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }   
               
        }

    }
}

