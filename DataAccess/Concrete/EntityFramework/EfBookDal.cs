using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, BookStoreDatabaseContext>, IBookDal
    {
        public List<BookDetailDto> GetProductDetails()
        {
            using (BookStoreDatabaseContext context = new BookStoreDatabaseContext())
            {
                var result = from book in context.Books
                    join category in context.Categories on book.CategoryId equals category.Id
                    join author in context.Authors on book.AuthorId equals author.Id
                    select new BookDetailDto()
                    {
                        BookName = book.BookName,
                        CategoryName = category.Name,
                        AuthorName = author.FirstName + " " +author.LastName,
                        UnitsInStock = book.UnitsInStock,
                        Price = book.Price,
                        Description = book.Decription
                    };
                return result.ToList();
            }
        }
    }
}
