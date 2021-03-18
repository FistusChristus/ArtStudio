using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStudio.Models
{
    public class BaseDBObject
    {
        [Key]
        public Guid Id { get; set; }
        public string DisplayAlias { get; set; }
        public bool Enabled { get; set; }
    }
    public class EntityData:BaseDBObject
    {
        public string Description { get; set; }
    }

    public class Resource : EntityData
    {
        public string URL { get; set; }
        public string Resolution { get; set; }
        public string Size { get; set; }
        public string Tags { get; set; }
        public double Price { get; set; }
        Category Category { get; set; }
        Guid CategoryId { get; set; }
    }

    public class Photo : Resource
    {
    }
    public  class Video : Resource
    {
    }

    public class Section: EntityData
    {
    }

    public class Category : EntityData
    {
        Section Section { get; set; }
        Guid SectionId { get; set; }
    }
    public class Package: EntityData
    {
        public int CountOfDownlaods { get; set; }
        public double Price { get; set; }
    }   
    public class PackageBuyInfo: EntityData
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Guid ApplicationUserId { get; set; }
    }
}
