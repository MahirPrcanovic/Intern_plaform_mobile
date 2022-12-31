using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Models;

namespace InternshipPlatform_API.Services.SelectionService
{
    public interface ISelectionService
    {
        Task<GlobalResponse<List<Selection>>> GetAll();
        Task<GlobalResponse<Selection>> Create(SelectionCreateDto createData);
    }
}
