using TH17012026.Application.Interfaces;
using TH17012026.Domain.Entities;

namespace TH17012026.Application.Services
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository;

        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public async Task<IEnumerable<Classes>> GetAllClassesAsync()
        {
            return await _classRepository.GetAllAsync();
        }

        public async Task<Classes?> GetClassByIdAsync(int id)
        {
            return await _classRepository.GetByIdAsync(id);
        }

        public async Task<Classes> CreateClassAsync(Classes classes)
        {
            return await _classRepository.AddAsync(classes);
        }
    }
}
