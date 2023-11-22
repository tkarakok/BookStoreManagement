using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        DataResult<List<Employee>> GetEmployees();
        List<OperationClaim> GetClaims(Employee user);
        void Add(Employee user);
        Employee GetByMail(string email);

        DataResult<List<EmployeeDetailDto>> GetEmployeeDetails();
    }
}
