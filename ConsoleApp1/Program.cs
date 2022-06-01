using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //CarTest(carManager);
            //BrandTest();
            //CarDetailTest(carManager);
        }

        private static void CarTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarId + "/" + car.BrandId + "/" + car.CarName);
            }
        }

        private static void BrandTest()
        {
            Brand brand1 = new Brand { BrandId = 208, BrandName = "peugeot" };
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(brand1);

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarDetailTest(CarManager carManager)
        {
            foreach (var carDetail in carManager.GetCarDetail().Data)
            {
                Console.WriteLine(carDetail.CarId + "/" + carDetail.CarName + "/" + carDetail.BrandName + "/" + carDetail.ColorName + "/" + carDetail.DailyPrice);
            }
        }
    }
}
