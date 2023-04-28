using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _ımageDal;

        public ImageManager(IImageDal ımageDal)
        {
            _ımageDal = ımageDal;
        }

        public void Delete(Image t)
        {
            _ımageDal.Delete(t);
        }

        public List<Image> GetAll()
        {
            return _ımageDal.GetAll();
        }

        public Image GetById(int id)
        {
            return _ımageDal.GetById(id);
        }

        public void Insert(Image t)
        {
            _ımageDal.Insert(t);
        }

        public void Update(Image t)
        {
            _ımageDal.Update(t);
        }
    }
}
