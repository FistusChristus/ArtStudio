using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtStudio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArtStudio
{

    public class ApplicationDBContext : IdentityDbContext<ApplicationUser,ApplicationRole, string>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
       
        }
        //with CRUD
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Package> Packages { get; set; }


        //without CRUD
        public DbSet<PackageInfo> PackageInfos { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<UserCartContent> UserCartContents { get; set; }

    }
}
