using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;
using ArtStudio.Models;
using System.Collections.Generic;
using ArtStudio.Services;
using Microsoft.EntityFrameworkCore;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Core;

namespace ArtStudio.Controllers
{
    public class FileController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserService _userService;
        private readonly SessionService _sessionService;
        IWebHostEnvironment _appEnvironment;
        private class FileTransfer
        {
            public FileTransfer(string path, string name)
            {
                Path = path;
                FileName = name;
            }
            public string Path { get; set; }
            public string FileName { get; set; }

        }
        public FileController(ApplicationDBContext context, IWebHostEnvironment appEnvironment, SessionService sessionService, UserService userService)
        {
            _context = context;
            _appEnvironment = appEnvironment;
            _sessionService = sessionService;
            _userService = userService;
        }
        //if (resourceFile != null)
        //{
        //    string filePath = Path.Combine(_appEnvironment.WebRootPath+resourceFile.ResourceFilePath);
        //    string fileType = resourceFile.ContentType;
        //    return PhysicalFile(filePath, fileType, fileName+".rar");
        //}
        //return Ok();
        [HttpGet]
        public async Task<IActionResult> DownloadAllCart()
        {
            if (!_userService.IsCanDownload())
                return NotFound();

            Session session = _sessionService.GetSession();
            List<UserCartContent> userCartContents = _context.UserCartContents.Include(c => c.Resource).Where(c => c.ApplicationUserId == session.Id).ToList();
            List<Resource> resourcesInCart = userCartContents.Select(c => c.Resource).ToList();
            List<FileTransfer> transferFilesList = new List<FileTransfer>();
            foreach (var resource in resourcesInCart)
            {
                string path = _context.ResourceFiles.FirstOrDefault(r => r.ResourceId == resource.Id).ResourceFilePath;
                transferFilesList.Add(new FileTransfer(path, resource.DisplayAlias));
            }

            MemoryStream outputMemStream = new MemoryStream();
            ZipOutputStream zipStream = new ZipOutputStream(outputMemStream);
            zipStream.SetLevel(3);

            foreach (var transferFile in transferFilesList)
            {
                string filename = transferFile.FileName + ".rar";
                ZipEntry newEntry = new ZipEntry(filename);
                zipStream.PutNextEntry(newEntry);
                byte[] buffer = new byte[4096];
                using (Stream fileStream = new FileStream(Path.Combine(_appEnvironment.WebRootPath + transferFile.Path), FileMode.OpenOrCreate))
                {
                    StreamUtils.Copy(fileStream, zipStream, buffer);
                }
                zipStream.CloseEntry();
                zipStream.IsStreamOwner = false;
            }
            zipStream.Close();
            outputMemStream.Position = 0;
            string file_type = "application/zip";
            await _userService.ClearResourcesInCart(userCartContents);
            await _userService.ReduceCountOfDownload(transferFilesList.Count);
            return File(outputMemStream, file_type, "SonyPhotography" + ".rar");
        }
    }
}
