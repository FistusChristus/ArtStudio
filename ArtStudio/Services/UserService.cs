using ArtStudio.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
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


    public class UserService
    {

        public readonly ApplicationDBContext dbContext;
        public readonly SessionService sessionService;
        public readonly UserManager<ApplicationUser> userManager;
        public UserService(ApplicationDBContext dbContext, UserManager<ApplicationUser> userManager, SessionService sessionService)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.sessionService = sessionService;
        }

        public async Task<bool> UpdateUserData(ApplicationUser user)
        {

            var result = await userManager.UpdateAsync(user);
            return result.Succeeded;
        }
        public bool IsCanDownload()
        {
            return GetUserCountOfDownloads() > 0;
        }
        public int GetUserCountOfDownloads()
        {
            string userId = sessionService.GetUserId();
            var user = dbContext.Users.FirstOrDefault(u => u.Id == userId);
            return user.CountOfDownload;
        }
        public int GetUserCountOfPackages()
        {
            return dbContext.PaymentInfos.Where(p => p.ApplicationUserId == sessionService.GetUserId()).Count();
        } 
        public async Task ReduceCountOfDownload(int count)
        {
            string userId = sessionService.GetUserId();
            var user = dbContext.Users.FirstOrDefault(u => u.Id == userId);
            user.CountOfDownload -= count;
            user.CountOfSuccessDownload += count;
            await userManager.UpdateAsync(user);
        }
        public async Task AddCountOfDownload(int count)
        {
            string userId = sessionService.GetUserId();
            var user = dbContext.Users.FirstOrDefault(u => u.Id == userId);
            user.CountOfDownload = count;
            await userManager.UpdateAsync(user);
        }
        public async Task ClearResourcesInCart(List<UserCartContent> userCartContents)
        {
            foreach (var item in userCartContents)
            {
                item.Enabled = false;
            }
            dbContext.UserCartContents.UpdateRange(userCartContents);
            await dbContext.SaveChangesAsync();
        }
    }
}
