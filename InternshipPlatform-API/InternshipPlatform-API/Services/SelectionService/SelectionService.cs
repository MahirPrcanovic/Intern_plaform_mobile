using AutoMapper;
using InternshipPlatform_API.Data;
using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Models;
using Microsoft.EntityFrameworkCore;

namespace InternshipPlatform_API.Services.SelectionService
{
    public class SelectionService : ISelectionService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public SelectionService(DataContext dataContext,IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
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

        public async Task<GlobalResponse<Selection>> Create(SelectionCreateDto createData)
        {
            var response = new GlobalResponse<Selection>();
            try
            {
                var mappedSelection = this._mapper.Map<Selection>(createData);
                this._dataContext.Selections.Add(mappedSelection);
                await this._dataContext.SaveChangesAsync();
                response.Data = mappedSelection;
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
