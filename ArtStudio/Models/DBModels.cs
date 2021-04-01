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
        [Display(Name = "Идентификатор")]
        [Required(ErrorMessage = "Не указан Id")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        [Display(Name = "Имя")]
        public string DisplayAlias { get; set; }
        [Display(Name = "Используеться")]
        public bool Enabled { get; set; }
    }
    public class EntityData:BaseDBObject
    {
        [Display(Name = "Описание")]
        public string Description { get; set; }
    }

    public class Resource : EntityData
    {
        [Display(Name = "Ссылка на источник")]
        public string URL { get; set; }
        [Display(Name = "Разрешение")]
        public string Resolution { get; set; }
        [Display(Name = "Размер")]
        public string Size { get; set; }
        [Display(Name = "Теги")]
        public string Tags { get; set; }
        public Category Category { get; set; }
        [Display(Name = "Категория")]
        public Guid CategoryId { get; set; }
    }

    public class ResourceFile : EntityData
    {
        public string ResourceFilePath { get; set; }
        public string ContentType { get; set; }
        public Resource Resource { get; set; }
        public Guid ResourceId { get; set; }
    }

    public class Photo : Resource
    {
    }

    public class Category : EntityData
    {
    }
    public class Package: EntityData
    {
        public int CountOfDownlaods { get; set; }
        public double Price { get; set; }
        public int Order { get; set; }
    }   
    public class PaymentInfo: EntityData
    {
        public DateTime StartDate { get; set; }
        public Package Package { get; set; }
        public Guid PackageId { get; set; }
        public DateTime EndDate { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public int CountOfDownload { get; set; }
    }
    public class UserCartContent : EntityData
    {
        public Guid ResourceId { get; set; }
        public Resource Resource { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
    }
}
