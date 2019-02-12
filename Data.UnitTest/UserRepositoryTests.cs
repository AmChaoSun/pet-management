using Data.Repositories;
using Data.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitTest
{
    class UserRepositoryTests
    {

        private IUserRepository GetInMemoryUserRepository()
        {
            DbContextOptions<PetManagementContext> options;
            var builder = new DbContextOptionsBuilder<PetManagementContext>();
            builder.UseInMemoryDatabase();
            options = builder.Options;
            PetManagementContext petManagementContext = new PetManagementContext(options);
            petManagementContext.Database.EnsureDeleted();
            petManagementContext.Database.EnsureCreated();
            return new UserRepository(petManagementContext);
        }
    }

    
}
