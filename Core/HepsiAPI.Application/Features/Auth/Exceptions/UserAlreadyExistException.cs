using HepsiAPI.Application.Bases;

namespace HepsiAPI.Application.Features.Auth.Exceptions
{
    public class UserAlreadyExistException : BaseException
    {
        public UserAlreadyExistException() : base("Böyle bir kullanıcı zaten var!") { }
    }
}
