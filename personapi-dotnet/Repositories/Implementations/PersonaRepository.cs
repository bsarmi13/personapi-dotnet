using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Repositories.Interfaces;

namespace personapi_dotnet.Repositories.Implementations
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly PersonaDbContext _context;
        public PersonaRepository(PersonaDbContext context) => _context = context;

        public async Task<IEnumerable<Persona>> GetAllAsync() =>
            await _context.Personas.ToListAsync();

        public async Task<Persona?> GetByIdAsync(int cc) =>
            await _context.Personas.FindAsync(cc);

        public async Task AddAsync(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Persona persona)
        {
            _context.Personas.Update(persona);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int cc)
        {
            var entity = await _context.Personas.FindAsync(cc);
            if (entity != null)
            {
                _context.Personas.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
