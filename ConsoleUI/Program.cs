using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager _carManager = new CarManager(new EfCarDal());

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


            //CarTest();
            //getAllCar(carManager);


            BrandManager _brandManager = new BrandManager(new EfBrandDal());
            ColorManager _colorManager = new ColorManager(new EfColorDal());

            TEST(_carManager, _brandManager);


        }

        private static void TEST(CarManager carManager, BrandManager brandManager)
        {
            Console.WriteLine("     MARKALAR    ");
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            
            Console.WriteLine("     BrandId'si 2 olan araçlar       ");
            foreach (var car in carManager.GetCarsByBrandId(2).Data)
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("     ColorId' si 1 olan araçların modelyılı      ");
            foreach (var car in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(car.ModelYear);
            }
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Id + " / " + car.DailyPrice + "/" + car.Description);
                }

                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }

        private static void getAllCar(CarManager carManager)
        {
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0} model {1} lira {2}", car.ModelYear, car.DailyPrice, car.Description);
            }
        }

        private static void getByColorId(CarManager carManager)
        {
            var result = carManager.GetCarsByColorId(1);

            foreach (var car in result.Data)
            {
                Console.WriteLine("{0} model {1} lira {2}", car.ModelYear, car.DailyPrice, car.Description);
            }
        }
    }

}