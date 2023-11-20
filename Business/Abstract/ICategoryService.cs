using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Business.BusinessAbstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICategoryService : IService<Category>
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetCategoryById(int id);
        IDataResult<List<CategoryDetailsDto>> GetCategoryDetails();

    }
}
