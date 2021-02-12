using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businnes.Abstract
{
    interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        void Add(Car car);
    }
}
