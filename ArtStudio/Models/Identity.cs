using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStudio.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public int CountOfDownload { get; set; }
        public int CountOfSuccessDownload { get; set; }
    }

    public class ApplicationRole : IdentityRole
    {
    }
}
