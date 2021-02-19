using Core.DataAccess.EntityFramework;
using DataAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    class EfRentalDal: EfEntityRepositoryBase<Rental,RentACarContext>, IRentalDal
    {
    }
}
