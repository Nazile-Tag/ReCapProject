using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, ReCapDbContext>, ICarImageDal
    {
        public bool IsExist(int id)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                return context.CarImages.Any(p => p.Id == id);
            }
        }

    }
}
