using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ArtStudio.Models
{
    public class Session
    {
        public ClaimsPrincipal User { get; set; }
    }
}
