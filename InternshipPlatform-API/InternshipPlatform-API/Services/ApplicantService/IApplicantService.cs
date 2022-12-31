using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Dto.Response;
using InternshipPlatform_API.Dto;

namespace InternshipPlatform_API.Services.ApplicantService
{
    public interface IApplicantService
    {

        Task<GlobalResponse<List<ApplicantDto>>> GetAll();
        Task<GlobalResponse<ApplicantCreateDto>> Create(ApplicantCreateDto formData);
    }
}
