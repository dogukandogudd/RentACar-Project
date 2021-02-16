using Businnes.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businnes.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            Console.WriteLine("Being Added ... ");
            _brandDal.Add(brand);
            Console.WriteLine(brand.BrandName + " Added Successful!");
        }

        public void Delete(Brand brand)
        {
            Console.WriteLine("Wiping Out ...");
            _brandDal.Delete(brand);
            Console.WriteLine(brand.BrandName + " Deleted Successful!");
        }

        public List<Brand> GetAll()
        {
            Console.WriteLine("Listing ...");
            Console.WriteLine("Listing Successful!");
            return _brandDal.GetAll();          
        }

        public Brand GetByBrandId(int brandId)
        {
            Console.WriteLine("Listing ...");
            Console.WriteLine("Listing by Brand Successful!");
            return _brandDal.Get(b => b.BrandId == brandId);          
        }

        public void Update(Brand brand)
        {
            Console.WriteLine("Updating ...");
            _brandDal.Update(brand);
            Console.WriteLine( brand.BrandName+ " Updated Successful!");
        }
    }
}
