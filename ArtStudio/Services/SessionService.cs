using ArtStudio.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static ArtStudio.Data.Interfaces.Interfaces;

namespace ArtStudio.Services
{

    public class SessionService
    {
        private Session session { get; set; }

        private readonly ApplicationDBContext dbcontext;
        public bool IsAuthenticated { get; set; }
        public SessionService(ApplicationDBContext dbcontext, IHttpContextAccessor httpContextAccessor)
        {
            this.dbcontext = dbcontext;

            session = new Session();
            session.User = httpContextAccessor.HttpContext.User;
            if (session.User.Identity.IsAuthenticated)
            {
                session.Id = Guid.Parse(GetUserId());
                session.Name = GetUserName();
            }
        }
        public void SetSession(ClaimsPrincipal user)
        {
            session.User = user;
            IsAuthenticated = user.Identity.IsAuthenticated;
        }

        public Session GetSession()
        {
            return session.Id != Guid.Empty ? session : null;
        }
        public string GetUserId()
        {
            return session.User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        }
        public string GetUserName()
        {
            return session.User.Identity.Name;
        }
        public ApplicationUser GetUserData()
        {
            return dbcontext.Users.FirstOrDefault(u => u.UserName == session.User.Identity.Name);
        }

        public void RemoveSession()
        {
            session = new Session();
            IsAuthenticated = false;
        }
    }
}
