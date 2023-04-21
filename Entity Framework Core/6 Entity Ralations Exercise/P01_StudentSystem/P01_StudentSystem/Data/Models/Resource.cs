using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace P01_StudentSystem.Data.Models
{
    public class Resource
    {
      
        [Key]
        public int ResourceId { get; set; }


        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; } = null!;

        [Required]
        [Unicode(false)]
        [MaxLength(2048)]
        public string Url { get; set; } = null!;

        [Required]
        public ResourceType ResourceType { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        public Course Course { get; set; } = null!;
    }
}
