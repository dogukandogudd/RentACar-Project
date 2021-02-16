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

            //ListCar();
            //EfBranIdTest();
            //EfColorIdTest();

            //---------------

            //ListBrand();

            //---------------

            //ListColor(); 


            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {

                Console.WriteLine(car.BrandName + " / " + car.Description + " / " + car.ColorName );
            }

        }

        private static void ListColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void ListBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void EfColorIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var brand in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine("Rengi #" + brand.ColorId + " Gri olanlar listelendi.");
                Console.WriteLine(brand.Description);
            }
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

        private static void ListCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + "(" + car.ModelYear + ")" + " Günlük Fiyat: " + car.DailyPrice + " TL");
            }
        }

    }
}
