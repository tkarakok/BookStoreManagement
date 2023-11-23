using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;
        private ICustomerDal _customerDal;
        private IBookDal _bookDal;

        public RentalManager(IRentalDal rentalDal, IBookDal bookDal, ICustomerDal customerDal)
        {
            _rentalDal = rentalDal;
            _bookDal = bookDal;
            _customerDal = customerDal;
        }

        public IResult Add(Rental entity)
        {
            
            return new SuccessResult(Messages.RentalSucces);
        }

        public IResult Update(Rental entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Rental entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult NewRental(RentalDto rentalDto)
        {
            var _customer = _customerDal.Get(c => c.Email == rentalDto.CustomerEmail);
            var _book = _bookDal.Get(b => b.BookName == rentalDto.BookName);
            var rental = new Rental
            {
                CustomerId = _customer.Id,
                BookId = _book.Id,
                RentalDate = DateTime.Now.Date.Day,
            };
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalSucces);
        }
    }
}
