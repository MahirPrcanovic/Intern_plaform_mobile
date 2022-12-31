using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Dto.Response;
using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Models;

namespace InternshipPlatform_API.Services.ApplicantService
{
    public interface IApplicantService
    {

        Task<GlobalResponse<List<ApplicantDto>>> GetAll();
        Task<GlobalResponse<ApplicantCreateDto>> Create(ApplicantCreateDto formData);
        Task<GlobalResponse<Applicant>> GetSingle(Guid id);
    }
}
