using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Models;

namespace InternshipPlatform_API.Services.CompanyService
{
    public interface ICompanyService
    {
        Task<GlobalResponse<List<Company>>> GetAll();
    }
}
