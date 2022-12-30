using System.ComponentModel.DataAnnotations;

namespace InternshipPlatform_API.Models
{
    public class Applicant
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string EducationLevel { get; set; } = String.Empty;
        [Required]
        [MaxLength(300)]
        public string CoverLetter { get; set; } = string.Empty;
        [Required]
        public string CV { get; set; } = string.Empty;
        public List<Selection>? Selections { get; set; }
    }
}
