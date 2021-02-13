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
            //CarTest();

            //BrandTest();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Description + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }


            //carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = 100, ModelYear = 2021, Description = "Otomatik Dizel" });
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName = "a" });



        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine(brandManager.GetById(1).BrandName);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetByDailyPrice(10000, 12000))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
