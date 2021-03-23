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
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
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
        public  Section Section { get; set; }
        public Guid SectionId { get; set; }
    }
    public class Package: EntityData
    {
        public int CountOfDownlaods { get; set; }
        public double Price { get; set; }
        public int Order { get; set; }
    }   
    public class PackageInfo: EntityData
    {
        public DateTime StartDate { get; set; }
        public Package Package { get; set; }
        public Guid PackageId { get; set; }
        public DateTime EndDate { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Guid ApplicationUserId { get; set; }
    }
    public class UserCartContent : EntityData
    {
        public Guid ResourceId { get; set; }
        public Resource Resource { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Guid ApplicationUserId { get; set; }
    }
}
