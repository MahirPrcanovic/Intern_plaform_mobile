using InternshipPlatform_API.Data;
using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Models;
using Microsoft.EntityFrameworkCore;

namespace InternshipPlatform_API.Services.SelectionService
{
    public class SelectionService : ISelectionService
    {
        private readonly DataContext _dataContext;
        public SelectionService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<GlobalResponse<List<Selection>>> GetAll()
        {
          

        var response = new GlobalResponse<List<Selection>>();
            try
            {
                response.Data = await this._dataContext.Selections.ToListAsync();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
