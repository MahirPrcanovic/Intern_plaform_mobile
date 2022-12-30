namespace InternshipPlatform_API.Models
{
    public class Company
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public List<Selection>? Selections { get; set; }
    }
}
