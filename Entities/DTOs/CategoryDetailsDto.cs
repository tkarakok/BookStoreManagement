using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Entities.DTOs
{
    public class CategoryDetailsDto : IDto
    {
        public string CategoryName{ get; set; }
        public int BookCount{ get; set; }

    }
}
