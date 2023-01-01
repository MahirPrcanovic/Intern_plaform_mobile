using AutoMapper;
using InternshipPlatform_API.Data;
using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;

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
                response.Data = await this._dataContext.Selections.Include(c=>c.Applicants).ToListAsync();
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

        public async Task<GlobalResponse<Selection>> AddApplicant(Guid selectionId, Guid applicantId)
        {
            var response = new GlobalResponse<Selection>();
            try
            {
                var applicant = await this._dataContext.Applicants.Where(s => s.Id == applicantId).FirstOrDefaultAsync();
                var selection = await this._dataContext.Selections.Where(s => s.Id == selectionId).FirstOrDefaultAsync();
                if (applicant == null) throw new Exception("Applicant does not exist.");
                if (selection == null) throw new Exception("Selection does not exist.");
                if (selection.Applicants == null)
                {
                    selection.Applicants = new List<Applicant>() { };
                    selection.Applicants.Add(applicant);
                }
                else
                {
                    selection.Applicants.Add(applicant);
                }
                await this._dataContext.SaveChangesAsync();

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
