using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, BookStoreDatabaseContext>, IEmployeeDal
    {
        public List<OperationClaim> GetClaims(Employee user)
        {
            using (var context = new BookStoreDatabaseContext())
            {
                var result = from operationClaim in context.OperationClaims
                    join userOperationClaim in context.EmployeeOperationClaims
                        on operationClaim.Id equals userOperationClaim.OperationClaimId
                    where userOperationClaim.EmployeeId == user.Id
                    select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
