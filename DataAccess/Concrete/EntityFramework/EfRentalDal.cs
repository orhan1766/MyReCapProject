using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarDBContext>, IRentalDal
    {
        public List<RentalDto> GetRentalDetails()
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
               
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.CarId equals car.CarId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join customer in context.Customers
                             on rental.CustomerId equals customer.Id
                             join user in context.Users
                             on customer.UserId equals user.Id

                             select new RentalDto
                             {
                                 CarId = car.CarId,
                                 BrandName = brand.BrandName,
                                 FullName = user.FirstName + " " + user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate=rental.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
