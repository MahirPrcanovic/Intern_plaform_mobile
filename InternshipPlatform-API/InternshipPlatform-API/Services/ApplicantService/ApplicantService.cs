using AutoMapper;
using InternshipPlatform_API.Data;
using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Dto.Response;
using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Models;
using Microsoft.EntityFrameworkCore;

namespace InternshipPlatform_API.Services.ApplicantService
{
    public class ApplicantService : IApplicantService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public ApplicantService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<GlobalResponse<ApplicantCreateDto>> Create(ApplicantCreateDto formData)
        {
            var serviceResponse = new GlobalResponse<ApplicantCreateDto>();
            try
            {
                var insertData = _mapper.Map<Applicant>(formData);
                _dataContext.Applicants.Add(insertData);
                await _dataContext.SaveChangesAsync();
                serviceResponse.Data = formData;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<GlobalResponse<List<ApplicantDto>>> GetAll()
        {
            var response = new GlobalResponse<List<ApplicantDto>>();
            try
            {
                var applicants = _dataContext.Applicants.Select(p => new ApplicantDto()
                {
                    Id = p.Id,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Email = p.Email,
                    EducationLevel = p.EducationLevel
                });
                response.Data = await applicants.ToListAsync();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GlobalResponse<Applicant>> GetSingle(Guid id)
        {
            var response = new GlobalResponse<Applicant>();
            try
            {
                response.Data =await this._dataContext.Applicants.Include(a=>a.Selections).FirstOrDefaultAsync(a => a.Id == id);
                if (response.Data == null) throw new Exception("No applicant found.");
                
            }catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                
            }
            return response;
        }
    }
}
