using InternshipPlatform_API.Data;
using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Models;
using Microsoft.AspNetCore.Identity;

namespace InternshipPlatform_API.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly UserManager<ExtendUser> _userManager;
        private readonly DataContext _dataContext;
        public UserService(UserManager<ExtendUser> userManager,DataContext dataContext)
        {
            _userManager = userManager;
            _dataContext = dataContext;
        }

        public async Task<GlobalResponse<string>> Create(RegisterDto registerData)
        {
            var user = new ExtendUser { UserName = registerData.UserName };
            var result = await this._userManager.CreateAsync(user, registerData.Password);
            var serviceResponse = new GlobalResponse<string>();
            if (result.Succeeded)
            {
                serviceResponse.Data = user.Id;
                serviceResponse.Message = "Successfull register";
                this._dataContext.UserRoles.Add(new IdentityUserRole<string>
                {
                    RoleId = "413743e0-asd2–42fe-afbf-59kmccmk72cd6",
                    UserId = user.Id
                });
                await this._dataContext.SaveChangesAsync();
            }
            else
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Not successfull";
            }
            //SEND EMAIL TO registerData.email
            return serviceResponse;
        }

        public async Task<bool> Login(LoginDto login)
        {
            var _user = await _userManager.FindByNameAsync(login.UserName);
            var serviceResponse = new GlobalResponse<string>();
            //var result = await this._signInManager.PasswordSignInAsync(username, password, rememberMe, false);
            var result = _user != null && await _userManager.CheckPasswordAsync(_user, login.Password);
            return result;
        }
    }
}
