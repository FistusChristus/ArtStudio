using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStudio.Models
{
    public class Response
    {
        public string error { get; set; }
        public bool isSuccess { get; set; }
        public object data { get; set; }
        public Response(bool isSuccess, object data =null, string error=null)
        {
            this.isSuccess = isSuccess;
            this.data = data;
            this.error = error;
        }
    }
}
