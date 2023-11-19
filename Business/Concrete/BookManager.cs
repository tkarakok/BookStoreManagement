using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.AutoFac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public IDataResult<List<Book>> GetAllBooks()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll());
        }

        public IDataResult<Book> GetBookById(int id)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(b => b.Id == id));
        }

        [ValidationAspect(typeof(BookValidator))]
        public IResult Add(Book book)
        {
            IResult result = BusinessRules.Run(CheckIfProductNameExists(book.BookName));

            if (result != null)
            {
                return result;
            }

            _bookDal.Add(book);
            return new SuccessResult(Messages.BookAdded);
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult(Messages.BookUpdated);
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult(Messages.BookDeleted);
        }


        #region Business Rules

        private IResult CheckIfProductNameExists(string bookName)
        {
            var hasProductName = _bookDal.GetAll(b => b.BookName == bookName).Any();
            if (hasProductName)
                return new ErrorResult(Messages.BookNameExists);

            return new SuccessResult();
        }

        #endregion
    }
}
