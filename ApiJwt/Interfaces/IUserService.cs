using ApiJwt.Entities;
using ApiJwt.Models;
using System.Collections.Generic;

namespace ApiJwt.Interfaces
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
