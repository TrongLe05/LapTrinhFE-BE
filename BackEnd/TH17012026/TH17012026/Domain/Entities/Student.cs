using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TH17012026.Domain.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Classes? Class { get; set; }
    }
}
