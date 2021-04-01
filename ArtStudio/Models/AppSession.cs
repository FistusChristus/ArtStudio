using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ArtStudio.Models
{
    public class AppSession
    {
        public ClaimsPrincipal User { get; set; }
        public string Name { get; set; }
        public Guid Id{ get; set; }
        public ISession HttpContetSession{ get; set; }
    }
}
