using Microsoft.AspNetCore.Mvc;
using TH17012026.Application.Interfaces;
using TH17012026.Domain.Entities;

namespace TH17012026.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassesController : ControllerBase
    {
        private readonly IClassService _classService;

        public ClassesController(IClassService classService)
        {
            _classService = classService;
        }

        /// <summary>
        /// Lấy danh sách lớp
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Classes>>> GetAllClasses()
        {
            var classes = await _classService.GetAllClassesAsync();
            return Ok(classes);
        }

        /// <summary>
        /// Xem chi tiết lớp
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<Classes>> GetClassById(int id)
        {
            var classEntity = await _classService.GetClassByIdAsync(id);
            if (classEntity == null)
            {
                return NotFound(new { message = $"Không tìm thấy lớp với Id = {id}" });
            }
            return Ok(classEntity);
        }

        /// <summary>
        /// Tạo lớp mới
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<Classes>> CreateClass([FromBody] Classes classes)
        {
            var createdClass = await _classService.CreateClassAsync(classes);
            return CreatedAtAction(nameof(GetClassById), new { id = createdClass.Id }, createdClass);
        }
    }
}
