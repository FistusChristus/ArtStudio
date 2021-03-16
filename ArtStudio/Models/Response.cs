using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStudio.Models
{
    public class Response
    {
        public string error { get; set; }
        public bool status { get; set; }
        public object data { get; set; }
        public Response(bool status, object data =null, string error=null)
        {
            this.status = status;
            this.data = data;
            this.error = error;
        }
    }
}
