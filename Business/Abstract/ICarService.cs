using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Results;
using Entities.DTO;
using ReCapProject.Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    { 
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails(int id);
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int id);
        IResult Add(Car cars);
        IResult Update(Car cars);
        IResult Delete(Car cars);
        
    }
}
