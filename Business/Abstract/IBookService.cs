using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Business.BusinessAbstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBookService : IService<Book>
    {
        IDataResult<List<Book>> GetAllBooks();
        IDataResult<Book> GetBookById(int id);
    }
}
