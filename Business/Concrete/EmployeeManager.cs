using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _userDal;

        public EmployeeManager(IEmployeeDal userDal)
        {
            _userDal = userDal;
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
    }
}
