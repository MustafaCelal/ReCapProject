using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("{0} model {1} lira {2}",car.ModelYear,car.DailyPrice,car.Description);
            //}

            var result = carManager.GetCarsByColorId(1);

            foreach (var car in result)
            {
                Console.WriteLine("{0} model {1} lira {2}", car.ModelYear, car.DailyPrice, car.Description);
            }

        }

    }

}