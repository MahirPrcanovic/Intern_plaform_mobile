﻿namespace InternshipPlatform_API.Dto.Request
{
    public class ApplicantCreateDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string EducationLevel { get; set; } = string.Empty;
        public string CoverLetter { get; set; } = string.Empty;
        public string Cv { get; set; } = string.Empty;
    }
}
