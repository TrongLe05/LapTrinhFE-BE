using System.ComponentModel.DataAnnotations;

namespace TH17012026.Domain.Entities
{
    public class Classes
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
