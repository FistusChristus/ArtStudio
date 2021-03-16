using ArtStudio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArtStudio.Services
{

    public class RequestService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly SessionService sessionService;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IConfiguration configuration;

        public RequestService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            SessionService sessionService, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.sessionService = sessionService;
            this.httpContextAccessor = httpContextAccessor;
            this.configuration = configuration;
        }

        public async Task<Response> SendRequest(string url, object data)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(configuration.GetSection("BaseUrl").Value);
                var content = new StringContent(JsonSerializer.Serialize(data));
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                var result = await client.PostAsync(url, content);
                var responseMsg = await result.Content.ReadAsStringAsync();
                var response = JsonSerializer.Deserialize<Response>(responseMsg);
                return response;
            };
        }
    }
}
