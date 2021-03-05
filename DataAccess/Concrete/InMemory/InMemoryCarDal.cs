using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTO;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal 
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 50000, ModelYear = "2010" , Description = "First Hand"},
                new Car{Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 60000, ModelYear = "2012" , Description = "First Hand"},
                new Car{Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 55000, ModelYear = "2010" , Description = "First Hand"},
                new Car{Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 66000, ModelYear = "2012" , Description = "First Hand"},
                new Car{Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 55000, ModelYear = "2012" , Description = "First Hand"}

            };
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Add(Car cars)
        {
            _cars.Add(cars);
        }

        public void Update(Car cars)
        {
            Car carsToUpdate = _cars.SingleOrDefault(c => c.Id == cars.Id);
            carsToUpdate.BrandId = cars.BrandId;
            carsToUpdate.ColorId = cars.ColorId;
            carsToUpdate.ModelYear = cars.ModelYear;
            carsToUpdate.DailyPrice = cars.DailyPrice;
            carsToUpdate.Description = cars.Description;

        }

        public void Delete(Car cars)
        {
            Car carsToDelete = _cars.SingleOrDefault(c => c.Id == cars.Id);

            _cars.Remove(carsToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
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

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
