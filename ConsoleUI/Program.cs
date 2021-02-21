using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager _carManager = new CarManager(new EfCarDal());
            BrandManager _brandManager = new BrandManager(new EfBrandDal());
            ColorManager _colorManager = new ColorManager(new EfColorDal());
            UserManager _userManager = new UserManager(new EfUserDal());
            RentalManager _rentalManager = new RentalManager(new EfRentalDal());
            CustomerManager _customerManager = new CustomerManager(new EfCustomerDal());

            WriteData(_rentalManager);


        }

        private static void WriteData(RentalManager obj)
        {
            Console.WriteLine("    rent     ");
            foreach (var e in obj.GetAll().Data)
            {
                Console.WriteLine(e.CarId + " - "+e.CustomerId + " - " +e.RentDate + " - " +e.ReturnDate );
            }
            
        }
    }

}