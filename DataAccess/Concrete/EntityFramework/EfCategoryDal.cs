using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, BookStoreDatabaseContext>, ICategoryDal
    {
        public List<CategoryDetailsDto> GetCategoryDetails()
        {
            using (BookStoreDatabaseContext context = new BookStoreDatabaseContext())
            {
                var result = from category in context.Categories
                    join book in context.Books on category.Id equals book.CategoryId into count
                    select new CategoryDetailsDto()
                    {
                        CategoryName = category.Name,
                        BookCount = count.Count()
                    };
                
                return result.ToList();
            }
        }
    }
}
