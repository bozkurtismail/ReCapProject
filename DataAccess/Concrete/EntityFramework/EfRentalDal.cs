using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental,bool>>filter=null)
        {
            using (ReCapContext contex=new ReCapContext())
            {
                var result = from r in filter is null ? contex.Rentals : contex.Rentals.Where(filter)
                             join c in contex.Cars on r.CarId equals c.CarId
                             join cu in contex.Customers on r.CustomerId equals cu.CustomerId
                             join u in contex.Users on cu.UserId equals u.UserId
                             join b in contex.Brands on c.BrandId equals b.BrandId
                             join co in contex.Colors on c.ColorId equals co.ColorId
                             select new RentalDetailDto
                             {
                                 RentalId           = r.RentalId,
                                 CustomerFirstName  =u.FirstName,
                                 CustomerLastName   =u.LastName,
                                 CustomerCompanyName=cu.CompanyName,
                                 CarName            =c.Description,
                                 BrandName          =b.BrandName,
                                 ColorName          =co.ColorName,
                                 DailyPrice         =c.DailyPrice,
                                 RentDate           =r.RentDate,
                                 ReturnDate         =r.ReturnDate

                             };
                return result.ToList();
            }
            
        }
    }
}
