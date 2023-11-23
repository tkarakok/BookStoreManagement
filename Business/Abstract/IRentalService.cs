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
    public interface IRentalService : IService<Rental>
    {
        IDataResult<List<Rental>> GetAll();
        IResult NewRental(RentalDto rentalDto);
    }
}
