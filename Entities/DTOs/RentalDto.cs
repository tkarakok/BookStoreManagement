using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Entities.DTOs
{
    public class RentalDto : IDto
    {
        public string CustomerEmail { get; set; }
        public string BookName { get; set; }
    }
}
