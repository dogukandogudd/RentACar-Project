using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //TestCarDetail();


            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //Rental rental = new Rental
            //{
            //    //Id = 3,
            //    CarId = 4,
            //    CustomerId = 3,
            //    RentDate = DateTime.Now,
            //    ReturnDate = null
            //};
            //IResult result = rentalManager.Add(rental);
            //if (!result.Success) Console.WriteLine(result.Message);
            ////rentalManager.Update(rental);
            ////rentalManager.Delete(rental);
            //rentalManager.GetAll().Data.ForEach(r => Console.WriteLine(r.CarId + " " + r.RentDate));

            //programcs baştan düzenlenecek
            //---------------
            //ListCar();
            //EfBranIdTest();
            //EfColorIdTest();
            //ListColor(); 
            ListBrand();

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

        //private static void ListColor()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorName);
        //    }
        //}

        private static void ListBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
        }

        //private static void EfColorIdTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var brand in carManager.GetCarsByColorId(3).Data)
        //    {
        //        Console.WriteLine("Rengi #" + brand.ColorId + " olanlar listelendi.");
        //        Console.WriteLine(brand.Description);
        //    }
        //}

        //private static void EfBranIdTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var brand in carManager.GetCarsByBrandId(1).Data)
        //    {
        //        Console.WriteLine("Markası #" + brand.BrandId + " olanlar listelendi.");
        //        Console.WriteLine(brand.Description);
        //    }
        //}

        private static void ListCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Name + "(" + car.ModelYear + ") " + car.Description +" "+ " Günlük Fiyat: " + car.DailyPrice + " TL");
            }
        }

    }
}
