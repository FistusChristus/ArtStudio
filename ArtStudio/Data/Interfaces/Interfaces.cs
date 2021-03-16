using ArtStudio.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ArtStudio.Data.Interfaces
{
    public class Interfaces
    {
        public interface IJSRuntimeService
        {
            public void InvokeScript(string functionName, object data);
        }  

    }
}
