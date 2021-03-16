using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStudio.Models
{
    public class LoginModel
    {
        [JsonProperty(PropertyName = "email")]
        [Required]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "rememberMe")]
        public bool RememberMe { get; set; }
    }
}
