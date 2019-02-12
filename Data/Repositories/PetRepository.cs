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
    public class PetRepository : GenericRepository<Pet>, IPetRepository
    {
        public PetRepository(PetManagementEntities context) : base(context)
        {
        }

        public IEnumerable<Diet> GetPetsByOwner(int id)
        {
            var pets = _context.Pets.Where(x => x.OwnerID == id).Join(_context.Diets, p => p.PetId, d => d.DietId, (p, d) => d);
            return pets;
        }
    }
}
