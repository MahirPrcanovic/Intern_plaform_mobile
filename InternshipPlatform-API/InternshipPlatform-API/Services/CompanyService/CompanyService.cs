using InternshipPlatform_API.Data;
using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Models;
using Microsoft.EntityFrameworkCore;

namespace InternshipPlatform_API.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        private readonly DataContext _dataContext;
        public CompanyService(DataContext dataContext)
        {
            _dataContext = dataContext;
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
