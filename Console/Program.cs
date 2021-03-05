using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.DataAccess.Concrete;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ICarDal carDal = new EfCarDal();

            foreach (var car in carDal.GetAll())
            {
                System.Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Description);
            }
        }
    }
}
