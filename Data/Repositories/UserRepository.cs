using Data.Database;
using Data.Repositories.interfaces;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(PetManagementEntities context) : base(context)
        {
        }
        public override User Add(User record)
        {
            if (_context.Users.Any(x => x.UserName == record.UserName)) { return null; }
            return base.Add(record);
        }
        public override IEnumerable<User> GetAll()
        {
            return base.GetAll();
        }
    }
}

    
  
    

