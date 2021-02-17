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

            //ListBrand();

            //---------------
            //Color & Brand Manager will be held !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //---------------

            //ListColor(); 


            TestCarDetail();

        }

        private static void TestCarDetail()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " / " + car.Description + " / " + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
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
            foreach (var brand in carManager.GetCarsByColorId(3).Data)
            {
                Console.WriteLine("Rengi #" + brand.ColorId + " olanlar listelendi.");
                Console.WriteLine(brand.Description);
            }
        }

        private static void EfBranIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var brand in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine("Markası #" + brand.BrandId + " olanlar listelendi.");
                Console.WriteLine(brand.Description);
            }
        }

        private static void ListCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description + "(" + car.ModelYear + ")" + " Günlük Fiyat: " + car.DailyPrice + " TL");
            }
        }

    }
}
