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
        [HttpPost]
        public async Task<IActionResult> Post(ApplicantCreateDto formData)
        {
            var response = await this._applicantService.Create(formData);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}
