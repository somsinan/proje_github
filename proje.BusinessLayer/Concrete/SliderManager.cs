﻿using proje.BusinessLayer.Abstract;
using proje.DataAccessLayer.Abstract;
using proje.entityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje.BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal SliderDal)
        {
            _sliderDal = SliderDal;
        }

        public void TDelete(int id)
        {
            _sliderDal.Delete(id);
        }

        public List<Slider> TGetAll()
        {
            return _sliderDal.GetAll();
        }

        public Slider TGetById(int id)
        {
            return _sliderDal.GetById(id);
        }

        public void TInsert(Slider entity)
        {
            _sliderDal.Insert(entity);
        }

        public void TUpdate(Slider entity)
        {
            _sliderDal.Update(entity);
        }
    }
}
