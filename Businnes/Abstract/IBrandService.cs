using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businnes.Abstract
{
     interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetByBrandId(int brandId);
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
        //List<BrandDetailDto> GetBrandDetails();
    }
}
