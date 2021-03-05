using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.DTO;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDbContext>, ICarDal
    { 
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var result = from ca in context.Cars
                             join co in context.Colors
                             on ca.Id equals co.Id
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             select new CarDetailDto
                             {
                                 Id = ca.Id,
                                 BrandId = br.Id,
                                 BrandName = br.Name,
                                 ColorId = co.Id,
                                 ColorName = co.Name,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 ModelYear = ca.ModelYear
                             };

                return result.ToList();
            }
        }
    }
}
