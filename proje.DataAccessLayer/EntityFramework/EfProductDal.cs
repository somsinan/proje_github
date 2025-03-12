using Microsoft.EntityFrameworkCore;
using proje.DataAccessLayer.Abstract;
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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly ProjeContext _context;
        public EfProductDal(ProjeContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductsListWithCategory()
        {
            var values =_context.Products.Include(x=> x.Category).ToList();
            return values;
        }
    }
}
