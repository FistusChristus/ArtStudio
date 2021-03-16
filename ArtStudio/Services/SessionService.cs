using ArtStudio.Models;
using Microsoft.AspNetCore.Components;
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
        public bool IsAuthenticated { get; set; }
        public SessionService()
        {
            session = new Session();
        }
        public void SetSession(ClaimsPrincipal user)
        {
            session.User = user;
            IsAuthenticated = user.Identity.IsAuthenticated;
        }

        public Session GetSession()
        {
            return session;
        }

        public void RemoveSession()
        {
            session = new Session();
            IsAuthenticated = false;
        }
    }
}
