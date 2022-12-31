using AutoMapper;
using InternshipPlatform_API.Data;
using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Models;
using Microsoft.EntityFrameworkCore;

namespace InternshipPlatform_API.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public CompanyService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<GlobalResponse<Company>> Create(CompanyCreateDto data)
        {
            var response = new GlobalResponse<Company>();
            try {
                var mappedCompany = this._mapper.Map<Company>(data);
                this._dataContext.Companies.Add(mappedCompany);
                await this._dataContext.SaveChangesAsync();
                response.Data = mappedCompany;
            }catch(Exception ex) {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GlobalResponse<List<Company>>> GetAll()
        {
            var response = new GlobalResponse<List<Company>>();
            try
            {
                response.Data = await this._dataContext.Companies.ToListAsync();
            }catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
