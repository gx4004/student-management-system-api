using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odev.Data.Entity;

public class StudentEntity
{
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required,MaxLength(50)]
    public string Name { get; set; } = null!;
    [Required]
    public string Class { get; set; }= null!;
    [Required]
    public string Address { get; set; }= null!;
}