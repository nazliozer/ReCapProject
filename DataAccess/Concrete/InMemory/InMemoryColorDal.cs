using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal
    {
        List<Color> _colors;

        public InMemoryColorDal()
        {
            _colors = new List<Color>()
            {
                new Color(){ ColorId = 1, ColorName = "Mavi"},
                new Color(){ ColorId = 2, ColorName = "Kırmızı"},
                new Color(){ ColorId = 3, ColorName = "Gri"},               
                new Color(){ ColorId = 4, ColorName = "Sarı"},                
                new Color(){ ColorId = 5, ColorName = "Kahverengi"},


            };
        }

        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(int colorId)
        {
            var colorToDelete = _colors.SingleOrDefault(c => c.ColorId == colorId);
            _colors.Remove(colorToDelete);
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public void Update(Color color)
        {
            var colorToUpdate = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            colorToUpdate.ColorName = color.ColorName;
        }
    }
}
