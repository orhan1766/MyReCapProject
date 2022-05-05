using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carList;
        public InMemoryCarDal()
        {
            _carList = new List<Car> { new Car {CarId=1,BrandId=1,ColorId=1,DailyPrice=600,ModelYear=2015,Description="Sedan" },
            new Car {CarId=2,BrandId=5,ColorId=10,DailyPrice=700,ModelYear=2016,Description="Hatcback" },
            new Car {CarId=3,BrandId=6,ColorId=11,DailyPrice=800,ModelYear=2017,Description="Sedan" },
            new Car {CarId=4,BrandId=7,ColorId=12,DailyPrice=900,ModelYear=2018,Description="Hatcback" }
            };
        }
        public void Add(Car car)
        {
            _carList.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletedCar = _carList.SingleOrDefault(c => c.CarId == car.CarId);
            _carList.Remove(deletedCar);
        }

        public List<Car> GetAll()
        {
            return _carList;
        }

        public Car GetById(int carId)
        {
            return _carList.SingleOrDefault(c=>c.CarId==carId);
        }

        public void Update(Car car)
        {
            Car updatedCar = _carList.SingleOrDefault(c => c.CarId == car.CarId);
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
        }
    }
}
