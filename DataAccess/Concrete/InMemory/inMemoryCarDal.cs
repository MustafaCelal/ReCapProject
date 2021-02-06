using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car(){Id = 1, BrandId = 2, ColorId = 1, DailyPrice = 150000, Description = "Son model", ModelYear = "2019"},
                new Car(){Id = 1, BrandId = 3, ColorId = 3, DailyPrice = 150000, Description = "parçaları ucuz",ModelYear = "2000"},
                new Car(){Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 150000, Description = "tam bir classic",ModelYear = "1950"},
                new Car(){Id = 1, BrandId = 4, ColorId = 2, DailyPrice = 150000, Description = "mercedes kalitesi",ModelYear = "1970"},
                new Car(){Id = 1, BrandId = 5, ColorId = 2, DailyPrice = 150000, Description = "eniştelere özel", ModelYear = "2010"}
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
    }
}