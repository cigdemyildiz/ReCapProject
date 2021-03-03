using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {

            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);



            //if (brand.BrandName.Length > 2)
            //{
            //    _brandDal.Add(brand);
            //    return new SuccessResult(Messages.BrandAdded);

            //    //Console.WriteLine("Marka başarıyla eklendi.");
            //}
            //else
            //{
            //    return new ErrorResult(Messages.InvalidBrandName);
            //    //Console.WriteLine($"Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz. Girdiğiniz marka ismi : {brand.BrandName}");
            //}
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);

            // Console.WriteLine("Marka başarıyla silindi.");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandListed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(c => c.BrandId == id));
        }


        [ValidationAspect(typeof(BrandValidator))]
        public IResult Update(Brand brand)
        {


            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);

            //if (brand.BrandName.Length >= 2)
            //{
            //    _brandDal.Update(brand);
            //    return new SuccessResult(Messages.BrandUpdated);
            //    //Console.WriteLine("Marka başarıyla Güncellendi.");
            //}
            //else
            //{
            //    return new ErrorResult(Messages.InvalidBrandName);
            //    //Console.WriteLine($"Lütfen marka isminin uzunluğunu 1 karakterden fazla giriniz. Girdiğiniz marka ismi : {brand.BrandName}");
            //}
        }
    }
}
