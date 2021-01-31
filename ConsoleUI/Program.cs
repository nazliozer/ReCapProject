using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll()) 
            {
                Console.WriteLine(" Model : {0}  Açıklama : {1}  Günlük Ücret : {2} TL" ,  car.ModelYear, car.Description, car.DailyPrice);

            }
            
        }
    }
}
