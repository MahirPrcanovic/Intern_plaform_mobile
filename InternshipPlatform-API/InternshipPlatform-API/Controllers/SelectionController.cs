using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Services.CompanyService;
using InternshipPlatform_API.Services.SelectionService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternshipPlatform_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelectionController : ControllerBase
    {
        private readonly ISelectionService _selectionService;
        public SelectionController(ISelectionService selectionService)
        {
            this._selectionService = selectionService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await this._selectionService.GetAll();
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post(SelectionCreateDto createData)
        {
            var response = await this._selectionService.Create(createData);
            if (response.Success)
            {
                return Created("", response);
            }
            return BadRequest(response);
        }
        [HttpPut("{selectionId}/{applicantId}")]
        public async Task<IActionResult> AddApplicant(Guid selectionId, Guid applicantId)
        {
            var response = await this._selectionService.AddApplicant(selectionId, applicantId);
            if (response.Success)
            {
                return Created("", response);
            }
            return BadRequest(response);
        }
    }
}
