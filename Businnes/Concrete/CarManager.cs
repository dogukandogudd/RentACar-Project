using Businnes.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Businnes.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                Console.WriteLine("Adding Successful...");
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araba ismi minimum 2 karakter ve günlük fiyatı 0'dan büyük olmalıdır. ");
            }
        }

        public List<Car> GetAll()
        {
            Console.WriteLine("Listing Successful...");
            return _carDal.GetAll();  
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            Console.WriteLine("Listing by Brand Successful...");
            var GetCarId = _carDal.GetAll(p => p.BrandId == brandId).ToList();
            return GetCarId;
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            Console.WriteLine("Listing by Color Successful...");
            var GetCar = _carDal.GetAll(c => c.ColorId == colorId).ToList();
            return GetCar;
        }
    }
}
