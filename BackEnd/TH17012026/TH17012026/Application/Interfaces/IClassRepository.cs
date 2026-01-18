using TH17012026.Domain.Entities;

namespace TH17012026.Application.Interfaces
{
    public interface IClassRepository
    {
        Task<IEnumerable<Classes>> GetAllAsync();
        Task<Classes?> GetByIdAsync(int id);
        Task<Classes> AddAsync(Classes classes);
        Task<bool> ExistsAsync(int id);
    }
}
