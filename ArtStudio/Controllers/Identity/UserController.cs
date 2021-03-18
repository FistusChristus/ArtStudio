
using ArtStudio.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using static ArtStudio.Data.Interfaces.Interfaces;
using System.Threading.Tasks;
using ArtStudio.Services;

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
        [HttpPost]
        [Route("register")]
        public async Task<Response> Register(RegisterModel model)
        {
            ApplicationUser user = new ApplicationUser { Email = model.Email, UserName = model.Email };
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, false);
                sessionService.SetSession(User);
            }

            return new Response(result.Succeeded, null, result.Errors.ToString());
        }

        [Route("login")]
        [HttpPost]
        public async Task<Response> Login(LoginModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                sessionService.SetSession(User);
            }
            string error = result.Succeeded ? "" : "Неверный логин или пароль";
            return new Response(result.Succeeded, null, error);
        }

        [Route("logout")]
        [HttpPost]
        public async Task<Response> LogOut()
        {
            await signInManager.SignOutAsync();
            return new Response(true, null, null);
        }
    }
}
