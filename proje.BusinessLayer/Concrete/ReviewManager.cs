using proje.BusinessLayer.Abstract;
using proje.DataAccessLayer.Abstract;
using proje.entityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje.BusinessLayer.Concrete
{
    public class ReviewManager :IReviewService
    {
        private readonly IReviewDal _reviewDal;

        public ReviewManager(IReviewDal ReviewDal)
        {
            _reviewDal = ReviewDal;
        }

        public void TDelete(int id)
        {
            _reviewDal.Delete(id);
        }

        public List<Review> TGetAll()
        {
            return _reviewDal.GetAll();
        }

        public Review TGetById(int id)
        {
            return _reviewDal.GetById(id);
        }

        public void TInsert(Review entity)
        {
            _reviewDal.Insert(entity);
        }

        public void TUpdate(Review entity)
        {
            _reviewDal.Update(entity);
        }
    }
}
