using Data.Database;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitTest
{
    public class PetManagementContext : DbContext
    {
        public PetManagementContext(){ }
        public PetManagementContext(DbContextOptions<PetManagementContext> options) : base(options){ }

        public virtual DbSet<Diet> Diets { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<AdminUser> AdminUsers { get; set; }
    }
}
}
