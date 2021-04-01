using ArtStudio.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArtStudio.Services
{

    public class JSRuntimeService
    {
        private readonly IJSRuntime JSRuntime;
        public JSRuntimeService(IJSRuntime JSRuntime)
        {
            this.JSRuntime = JSRuntime;
        }

        public async Task<Response> InvokeScript(string functionName, object data)
        {
            Response response = await JSRuntime.InvokeAsync<Response>(functionName, data);
            return response;
        }

    }
}
