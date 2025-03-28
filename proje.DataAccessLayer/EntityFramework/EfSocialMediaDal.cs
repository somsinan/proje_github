﻿using proje.DataAccessLayer.Abstract;
using proje.DataAccessLayer.Context;
using proje.DataAccessLayer.Repositories;
using proje.entityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje.DataAccessLayer.EntityFramework
{
    internal class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(ProjeContext context) : base(context)
        {
        }
    }
}
