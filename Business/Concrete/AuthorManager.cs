using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public IResult Add(Author entity)
        {
            _authorDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(Author entity)
        {
            _authorDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(Author entity)
        {
            _authorDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Author>> GetAllAuthor()
        {
            return new SuccessDataResult<List<Author>>(_authorDal.GetAll());
        }

        public IDataResult<Author> GetAuthor(int id)
        {
            return new SuccessDataResult<Author>(_authorDal.Get(a => a.Id == id));
        }
    }
}
