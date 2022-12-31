using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Dto.Response;
using InternshipPlatform_API.Models;
using InternshipPlatform_API.Services;
using InternshipPlatform_API.Services.ApplicantService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternshipPlatform_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly IApplicantService _applicantService;
        public ApplicantController(IApplicantService applicantService)
        {
            this._applicantService = applicantService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await this._applicantService.GetAll();
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(Guid id)
        {
            var response = await this._applicantService.GetSingle(id);
            if (response.Success)
            {
                return Ok(response);
            }
            return NotFound(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post(ApplicantCreateDto createApplicant){
            var response = await this._applicantService.Create(createApplicant);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);

        }
    }
}
