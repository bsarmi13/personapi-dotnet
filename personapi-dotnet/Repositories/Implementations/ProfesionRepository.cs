using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Repositories.Interfaces;

namespace personapi_dotnet.Repositories.Implementations
{
    public class ProfesionRepository : IProfesionRepository
    {
        private readonly PersonaDbContext _context;
        public ProfesionRepository(PersonaDbContext context) => _context = context;

        public async Task<IEnumerable<Profesion>> GetAllAsync() =>
            await _context.Profesions.ToListAsync();

        public async Task<Profesion?> GetByIdAsync(int id) =>
            await _context.Profesions.FindAsync(id);

        public async Task AddAsync(Profesion profesion)
        {
            await _context.Profesions.AddAsync(profesion);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Profesion profesion)
        {
            _context.Profesions.Update(profesion);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Profesions.FindAsync(id);
            if (entity != null)
            {
                _context.Profesions.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
