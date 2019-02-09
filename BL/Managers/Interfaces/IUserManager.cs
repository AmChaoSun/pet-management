using Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers.Interfaces
{
    public interface IUserManager
    {
        UserDisplayDto CreateUser(UserRegisterDto user);
        IEnumerable<UserDisplayDto> GetAll();
        UserDisplayDto GetUser(int Id);
        UserDisplayDto UpdateUser(int Id, UserDisplayDto user);
        void DeleteUser(int Id);
        
    }
}
