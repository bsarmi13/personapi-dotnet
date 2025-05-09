using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Repositories.Interfaces;

namespace personapi_dotnet.Repositories.Implementations
{
    public class EstudiosRepository : IEstudiosRepository
    {
        private readonly PersonaDbContext _context;
        public EstudiosRepository(PersonaDbContext context) => _context = context;

        public async Task<IEnumerable<Estudio>> GetAllAsync() =>
            await _context.Estudios.ToListAsync();

        public async Task<Estudio?> GetByIdAsync(int id) =>
            await _context.Estudios.FindAsync(id);

        public async Task AddAsync(Estudio estudio)
        {
            await _context.Estudios.AddAsync(estudio);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Estudio estudio)
        {
            _context.Estudios.Update(estudio);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Estudios.FindAsync(id);
            if (entity != null)
            {
                _context.Estudios.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
