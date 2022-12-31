using AutoMapper;
using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Models;
namespace InternshipPlatform_API
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ApplicantCreateDto, Applicant>();
            CreateMap<CompanyCreateDto,Company>();
            CreateMap<SelectionCreateDto, Selection>();
        }
    }
}
