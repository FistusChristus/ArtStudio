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
using static ArtStudio.Data.Interfaces.Interfaces;

namespace ArtStudio.Services
{

    public class EntityService
    {
        public readonly ApplicationDBContext dBContext;
        public EntityService(ApplicationDBContext dBContext)
        {
            this.dBContext = dBContext; 
        }
    }
}
