using ArtStudio.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using static ArtStudio.Data.Interfaces.Interfaces;

namespace ArtStudio.Services
{

    public class JSRuntimeService
    {
        private readonly ApplicationDBContext dbContext;
        private readonly IJSRuntime JSRuntime;
        public JSRuntimeService(ApplicationDBContext applicationDBContext, IJSRuntime JSRuntime)
        {
            dbContext = applicationDBContext;
            this.JSRuntime = JSRuntime;
        }

        public async Task<Response> InvokeScript(string functionName, object data)
        {
            Response response = await JSRuntime.InvokeAsync<Response>(functionName, data);
            return response;
        }

    }
}
