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

        public bool AddToCart(Guid userId, Guid resourceId)
        {
            if (String.IsNullOrEmpty(userId.ToString()) || String.IsNullOrEmpty(resourceId.ToString()))
                throw new ArgumentNullException();
            UserCartContent userCartContent = new UserCartContent { ApplicationUserId = userId, ResourceId = resourceId, Enabled = true, Id = Guid.NewGuid() };
            dBContext.UserCartContents.Add(userCartContent);
            dBContext.SaveChanges();
            return true;
        }   
        public bool DeleteInCart(Guid userId, Guid resourceId)
        {
            if (String.IsNullOrEmpty(userId.ToString()) || String.IsNullOrEmpty(resourceId.ToString()))
                throw new ArgumentNullException();
            UserCartContent userCartContent = dBContext.UserCartContents.FirstOrDefault(c=>c.ResourceId== resourceId && c.ApplicationUserId==userId);
            if(userCartContent==null)
                throw new NullReferenceException();

            dBContext.UserCartContents.Remove(userCartContent);
            dBContext.SaveChanges();
            return true;

        } 
        public Resource GetResource(string resourceId, string resourceType)
        {
            if (String.IsNullOrEmpty(resourceId) || String.IsNullOrEmpty(resourceType))
                throw new ArgumentNullException();

            Resource resource = null;
            if (resourceType.ToLower() == "video")
                resource = dBContext.Videos.Include(r => r.Category).FirstOrDefault(r => r.Id == Guid.Parse(resourceId) && r.Enabled);
            if (resourceType.ToLower() == "photo")
                resource = dBContext.Photos.Include(r => r.Category).FirstOrDefault(r => r.Id == Guid.Parse(resourceId) && r.Enabled);
            return resource;
        }
    }
}
