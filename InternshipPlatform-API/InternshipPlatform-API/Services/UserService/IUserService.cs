using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Dto.Request;

namespace InternshipPlatform_API.Services.UserService
{
    public interface IUserService
    {
        Task<GlobalResponse<string>> Post(RegisterDto register);
    }
}
