using Core.Entities.Concrete;
using Core.Entities.DTOs;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;

namespace Business.Abstract;

public interface IAuthService
{
    IDataResult<Employee> Register(EmployeeForRegisterDto userForRegisterDto, string password);
    IDataResult<Employee> Login(EmployeeForLoginDto userForLoginDto);
    IResult UserExists(string email);
    IDataResult<AccessToken> CreateAccessToken(Employee user);
}