using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;

namespace InternshipPlatform_API.Models
{
    public class Selection
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
        public ICollection<Applicant>? Applicants { get; set; }
      
    }
}
