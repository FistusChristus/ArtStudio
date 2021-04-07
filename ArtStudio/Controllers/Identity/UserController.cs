
using ArtStudio.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using ArtStudio.Services;
using System;

namespace ArtStudio.Controllers.Identity
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly SessionService sessionService;



        public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            SessionService sessionService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.sessionService = sessionService;

        }

        [Route("register")]
        [HttpPost]
        public async Task<Response> Register(RegisterModel model)
        {
            if (model.ConfirmPassword != model.Password)
                return new ErrorResponse("Пароли не совпадают");
            bool isUserExist = await userManager.FindByEmailAsync(model.Email) != null;
            if (isUserExist)
                return new ErrorResponse($"Пользователь с именем {model.Email} уже существует");
            if (!model.Email.Contains("@") || !model.Email.Contains("."))
                return new ErrorResponse("Не корректный email");

            ApplicationUser user = new ApplicationUser { Email = model.Email, UserName = model.Email };

            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, false);
                sessionService.SetSession(User, this.HttpContext);
            }
            else
            {
                string errors = "";
                foreach (var error in result.Errors)
                {
                    errors += String.Join('\n', error.Description);
                }
                return new ErrorResponse(errors);
            }
            return new OkResponse();
        }

        [Route("login")]
        [HttpPost]
        public async Task<Response> Login(LoginModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                sessionService.SetSession(User, this.HttpContext);
            }
            else
            {
                string error = result.Succeeded ? "" : "Неверный логин или пароль";
                return new ErrorResponse(error);
            }
            return new OkResponse();
        }

        [Route("logout")]
        [HttpPost]
        public async Task<Response> LogOut()
        {
            await signInManager.SignOutAsync();
            sessionService.RemoveSession(this.HttpContext);
            return new OkResponse();
        }
    }
}
