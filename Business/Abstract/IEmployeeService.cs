using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        List<OperationClaim> GetClaims(Employee user);
        void Add(Employee user);
        Employee GetByMail(string email);
    }
}
