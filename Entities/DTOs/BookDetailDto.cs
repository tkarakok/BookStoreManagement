using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Entities.DTOs
{
    public class BookDetailDto :IDto
    {
        public string  BookName { get; set; }
        public string  CategoryName { get; set; }
        public string  AuthorName { get; set; }
        public int  UnitsInStock { get; set; }
        public int Price { get; set; }
        public string Description{ get; set; }
    }
}
