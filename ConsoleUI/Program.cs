using Businnes.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //EfCarTest();
            EfBranIdTest();

        }

        private static void EfBranIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var brand in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Markası #" + brand.BrandId + " olanlar listelendi.");
                Console.WriteLine(brand.Description);
            }
        }

        private static void EfCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + "(" + car.ModelYear + ")" + " Günlük Fiyat: " + car.DailyPrice + " TL");
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + "(" + car.ModelYear + ")" + " Günlük Fiyat: " + car.DailyPrice + " TL");
            }
        }
    }
}
