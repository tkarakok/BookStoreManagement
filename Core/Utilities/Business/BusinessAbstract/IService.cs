using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business.BusinessAbstract
{
    public interface IService<T>
    {
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}
