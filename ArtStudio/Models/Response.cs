using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStudio.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public string Errors { get; set; }
        public Response()
        {
            this.IsSuccess = true;
            this.Errors = String.Empty;
        }
        public Response(bool IsSuccess, string Errors, int StatusCode)
        {
            this.IsSuccess = IsSuccess;
            this.Errors = Errors;
            this.StatusCode = StatusCode;
        }
    }
    public class OkResponse: Response
    {
        public OkResponse():base()
        {
            this.StatusCode = 200;
        }
    }
    public class ErrorResponse: Response
    {
        public ErrorResponse(string errors)
        {
            this.StatusCode = 403;
            this.IsSuccess = false;
            this.Errors = errors;
        }
    }
}
