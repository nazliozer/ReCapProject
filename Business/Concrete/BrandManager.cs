﻿using Business.Abstract;
using DataAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka eklendi.");
            }
            else
            {
                Console.WriteLine("Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz.");
            }
        }
        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka  silindi.");
        }
        public Brand GetById(int id)
        {
            return _brandDal.Get(c => c.BrandId == id);
        }
        public void Update(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka güncellendi.");
            }
            else
            {
                Console.WriteLine("Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz.");
            }
        }
    }
}
