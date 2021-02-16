using Businnes.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
                Console.WriteLine("Being Added ... ");               
                _carDal.Add(car);
                Console.WriteLine("Adding Successful...");
            }
            else
            {
                Console.WriteLine("The car name must be a minimum of 2 characters and the daily price must be greater than 0.");
            }
        }

        public void Delete(Car car)
        {
            Console.WriteLine("Wiping Out ...");
            _carDal.Delete(car);
            Console.WriteLine(car.Description + " Deleted Successful!");
        }

        public List<Car> GetAll()
        {
            Console.WriteLine("Listing ...");
            Console.WriteLine("Listing Successful...");
            return _carDal.GetAll();  
        }

        public List<CarDetailDto> GetCarDetails()
        {
            Console.WriteLine("Listing ...");
            Console.WriteLine("Brand / Model / Color by Listing Successful...");
            return _carDal.GetCarDetails();
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

        public void Update(Car car)
        {
            Console.WriteLine("Updating ...");
            _carDal.Update(car);
            Console.WriteLine(car.Description + " Updated Successful!");
        }
    }
}
