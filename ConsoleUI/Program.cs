using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //getAllCar(carManager);

            //getByColorId(carManager);


            //Add işlemi
            //carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 10000, Description = "Add fonksiyonu", ModelYear = "2000" });
            //getAllCar(carManager);

            // Update işlemi
            //carManager.Update(new Car { Id = 1003, BrandId = 2, ColorId = 2, DailyPrice = 20000, Description = "Update funksiyonu", ModelYear = "2020" });
            //getAllCar(carManager);


            // Delete İşlemi bu işlemde Id yi de girmemiz gerekiyor yoksa hata alıyoruz.
            //carManager.Delete(new Car { Id=1003,BrandId = 2, ColorId = 2, DailyPrice = 20000, Description = "Update funksiyonu", ModelYear = "2020" });
            //getAllCar(carManager);




        }

        private static void getAllCar(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} model {1} lira {2}", car.ModelYear, car.DailyPrice, car.Description);
            }
        }

        private static void getByColorId(CarManager carManager)
        {
            var result = carManager.GetCarsByColorId(1);

            foreach (var car in result)
            {
                Console.WriteLine("{0} model {1} lira {2}", car.ModelYear, car.DailyPrice, car.Description);
            }
        }
    }

}