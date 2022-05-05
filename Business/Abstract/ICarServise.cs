﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarServise    
    {
        List<Car> GetAll();
        Car GetById(int carId);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);


    }
}
