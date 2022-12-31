using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Services.CompanyService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternshipPlatform_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            this._companyService = companyService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await this._companyService.GetAll();
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CompanyCreateDto createData)
        {
            var response = await this._companyService.Create(createData);
            if (response.Success)
            {
                return Created("",response);
            }
            return BadRequest(response);
        }
    }
}
