using Businnes.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businnes.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color color)
        {
            Console.WriteLine("Being Added ... ");
            _colorDal.Add(color);
            Console.WriteLine(color.ColorName+" Adding Successful...");
        }

        public void Delete(Color color)
        {
            Console.WriteLine("Wiping Out ...");
            _colorDal.Delete(color);
            Console.WriteLine(color.ColorName + " Deleted Successful!");
        }

        public List<Color> GetAll()
        {
            Console.WriteLine("Listing ...");
            Console.WriteLine("Listing Successful...");
            return _colorDal.GetAll();
        }

        public Color GetByColorId(int colorId)
        {
            Console.WriteLine("Listing by Color Successful...");
            return _colorDal.Get(c => c.ColorId == colorId);
        }

        public void Update(Color color)
        {
            Console.WriteLine("Updating ...");
            _colorDal.Update(color);
            Console.WriteLine(color.ColorName + " Updated Successful!");
        }
    }
}
