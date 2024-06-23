using System.ComponentModel.DataAnnotations;

namespace LearnWeb_task_blazor.Models
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name is too long.")]

        public string? MaterialName { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "unique name is too long.")]
        public string? MaterialUniqueName { get; set; }

        public string? MaterialType { get; set; }

        public string? MaterialUse { get; set; }

        public string? Region { get; set; }

       
    }
}
