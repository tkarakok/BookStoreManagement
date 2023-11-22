using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _userDal;

        public EmployeeManager(IEmployeeDal userDal)
        {
            _userDal = userDal;
        }

        public DataResult<List<Employee>> GetEmployees()
        {
            return new SuccessDataResult<List<Employee>>(_userDal.GetAll());
        }


        public List<OperationClaim> GetClaims(Employee user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(Employee user)
        {
            _userDal.Add(user);
        }

        public Employee GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public DataResult<List<EmployeeDetailDto>> GetEmployeeDetails()
        {
            return new SuccessDataResult<List<EmployeeDetailDto>>(_userDal.GetEmployeeDetails().Data);
        }
    }
}
