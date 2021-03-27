using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetail()
        {
            using (ReCapContext contex=new ReCapContext())
            {
                var result = from c in contex.Customers
                             join u in contex.Users on c.UserId equals u.UserId
                             select new CustomerDetailDto
                             {
                                 CustomerId     = c.CustomerId,
                                 UserFirstName  =u.FirstName,
                                 UserLastName   =u.LastName,
                                 CompanyName    =c.CompanyName
                             };

                return result.ToList();
            }            
        }
    }
}
