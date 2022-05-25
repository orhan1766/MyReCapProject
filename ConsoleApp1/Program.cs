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
            //Brand brand1 = new Brand { BrandId=208,BrandName = "peugeot" };
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var carDetail in carManager.GetCarDetail())
            {
                Console.WriteLine(carDetail.CarId + "/" + carDetail.CarName + "/" + carDetail.BrandName + "/" + carDetail.ColorName + "/" + carDetail.DailyPrice);
            }
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId+"/"+car.BrandId+"/"+car.CarName);
            //}
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Delete(brand1);

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}
        }
    }
}
