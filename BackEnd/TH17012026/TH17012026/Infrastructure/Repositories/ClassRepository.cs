using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TH17012026.Application.Interfaces;
using TH17012026.Domain.Entities;
using TH17012026.Infrastructure.Data;

namespace TH17012026.Infrastructure.Repositories
{
    public class ClassRepository : IClassRepository
    {
        private readonly AppDbContext _context;

        public ClassRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Classes>> GetAllAsync()
        {
            return await _context.Classes.ToListAsync();
        }

        public async Task<Classes?> GetByIdAsync(int id)
        {
            return await _context.Classes.FindAsync(id);
        }

        public async Task<Classes> AddAsync(Classes classItem)
        {
            _context.Classes.Add(classItem);
            await _context.SaveChangesAsync();
            return classItem;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Classes.AnyAsync(c => c.Id == id);
        }
    }
}
