﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBookService
    {
        IDataResult<List<Book>> GetAllBooks();
        IDataResult<Book> GetBookById(int id);
        IResult Add(Book book);
        IResult Update(Book book);
        IResult Delete(Book book);
    }
}
