using DataAccess.Absract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {

                new Car {CarId = 1, BrandId=1, ColorId = 5, ModelYear="2010" , Description= "Opel Astra", DailyPrice = 100 },
                new Car {CarId = 2, BrandId=2, ColorId = 3, ModelYear="2007" , Description= "Toyota Corolla", DailyPrice = 250 },
                new Car {CarId = 3, BrandId=3, ColorId = 4, ModelYear="2018" , Description= "Suzuki Vitara", DailyPrice = 300 },
                new Car {CarId = 4, BrandId=4, ColorId = 1, ModelYear="2019" , Description= "BMW 5.20",  DailyPrice = 350},
                new Car {CarId = 5, BrandId=5, ColorId = 2, ModelYear="1970", Description= "Ford Mustang", DailyPrice = 450 },

            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
