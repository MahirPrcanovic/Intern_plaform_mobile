
namespace InternshipPlatform_API.Dto.Response
{
    public class ApplicantDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string EducationLevel { get; set; } = string.Empty;
    }
}
