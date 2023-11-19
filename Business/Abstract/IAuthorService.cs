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
    public interface IAuthorService : IService<Author>
    {
        IDataResult<List<Author>> GetAllAuthor();
        IDataResult<Author> GetAuthor(int id);

    }
}
