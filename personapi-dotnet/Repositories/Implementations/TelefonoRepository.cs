using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Repositories.Interfaces;

namespace personapi_dotnet.Repositories.Implementations
{
    public class TelefonoRepository : ITelefonoRepository
    {
        private readonly PersonaDbContext _context;
        public TelefonoRepository(PersonaDbContext context) => _context = context;

        public async Task<IEnumerable<Telefono>> GetAllAsync() =>
            await _context.Telefonos.ToListAsync();

        public async Task<Telefono?> GetByIdAsync(string num) =>
            await _context.Telefonos.FindAsync(num);

        public async Task AddAsync(Telefono telefono)
        {
            await _context.Telefonos.AddAsync(telefono);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Telefono telefono)
        {
            _context.Telefonos.Update(telefono);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string num)
        {
            var entity = await _context.Telefonos.FindAsync(num);
            if (entity != null)
            {
                _context.Telefonos.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
