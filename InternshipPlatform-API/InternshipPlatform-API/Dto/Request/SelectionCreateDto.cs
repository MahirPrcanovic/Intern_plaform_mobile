
namespace InternshipPlatform_API.Dto.Request
{
    public class SelectionCreateDto
    {
        public string Name { get; set; } = string.Empty;
      
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
