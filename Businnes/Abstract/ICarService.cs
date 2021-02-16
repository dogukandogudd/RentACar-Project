using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businnes.Abstract
{
    interface ICarService
    {
        List<Car> GetAll();
        List<CarDetailDto> GetCarDetails();
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

       

    }
}
