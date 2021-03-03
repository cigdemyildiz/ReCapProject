using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {

            
            //ValidationTool.Validate(new CarValidator(), car);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

            //if (car.DailyPrice > 0)
            //{
            //    _carDal.Add(car);
            //   // Console.WriteLine("Araba başarıyla eklendi.");
            //    return new SuccessResult(Messages.CarAdded);
            //}
            //else
            //{
            //    return new ErrorResult(Messages.InvalidDailyPrice);
            //    //Console.WriteLine($"Lütfen günlük fiyat kısmını 0'dan büyük giriniz. Girdiğiniz değer : {car.DailyPrice}");
            //}

        }

        public IResult Delete(Car car)
        {
           _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
            //Console.WriteLine("Araba başarıyla silindi.");
        }

        public IDataResult<List<Car>> GetAll()
        {

            return new SuccessDataResult<List<Car>>( _carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max), Messages.CarListedByDailyPrice);
        }

        public IDataResult< Car> GetById(int id)
        {
            return new SuccessDataResult<Car>( _carDal.Get(c => c.CarId == id));
           
        }

        public IDataResult<List<Car>> GetByModelYear(int year)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.ModelYear == year));
            //Contains(year) == true);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
           /* if (DateTime.Now.Hour == 11)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            } */

            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.ColorId == id));
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {

            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);

            //if (car.DailyPrice > 0)
            //{
            //    _carDal.Update(car);
            //    return new SuccessResult(Messages.CarUpdated);
            //    //Console.WriteLine("Araba başarıyla güncellendi.");
            //}
            //else
            //{
            //    return new ErrorResult(Messages.InvalidDailyPrice);
            //   // Console.WriteLine($"Lütfen günlük fiyat kısmını 0'dan büyük giriniz. Girdiğiniz değer : {car.DailyPrice}");
            //}
        }
    }
}
