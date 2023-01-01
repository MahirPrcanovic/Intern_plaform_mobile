using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Models;

namespace InternshipPlatform_API.Services.CompanyService
{
    public interface ICompanyService
    {
        Task<GlobalResponse<List<Company>>> GetAll();
        Task<GlobalResponse<Company>> Create(CompanyCreateDto data);
        Task<GlobalResponse<Selection>> AddSelection(Guid companyId, Guid selectionId);
    }
}
