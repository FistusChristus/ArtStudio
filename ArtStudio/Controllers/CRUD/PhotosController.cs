using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArtStudio;
using ArtStudio.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using System.Drawing;

namespace ArtStudio.Controllers
{
    [Authorize(Policy = "Admin")]
    public class PhotosController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly IWebHostEnvironment _appEnvironment;

        public PhotosController(ApplicationDBContext context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        // GET: Photos
        public async Task<IActionResult> Index()
        {
            var applicationDBContext = _context.Photos.Include(p => p.Category);
            return View(await applicationDBContext.ToListAsync());
        }

        // GET: Photos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (photo == null)
            {
                return NotFound();
            }

            return View(photo);
        }

        // GET: Photos/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories.OrderBy(c => c.DisplayAlias), "Id", "DisplayAlias");
            return View();
        }

        // POST: Photos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Tags,CategoryId,Description,Id,DisplayAlias,Enabled")] Photo photo, IFormFile uploadedFile, IFormFile resourceFile)
        {
            if (ModelState.IsValid)
            {
                photo.Id = Guid.NewGuid();

                if (uploadedFile != null)
                {
                    string path = "/files/" + uploadedFile.FileName;
                    using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.OpenOrCreate))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                        photo.Size = (fileStream.Length / 1000).ToString();
                        var img = Image.FromStream(fileStream);
                        photo.Resolution = img.Width + " x " + img.Height;
                    }
                    photo.URL = path;


                }

                _context.Add(photo);
                if (resourceFile != null)
                {
                    string path = "/resourceFiles/" + resourceFile.FileName;
                    using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.OpenOrCreate))
                    {
                        await resourceFile.CopyToAsync(fileStream);

                    }
                    ResourceFile resourceFileModel = new ResourceFile() { Id = Guid.NewGuid(), Enabled = true, ResourceFilePath = path, ResourceId = photo.Id, ContentType = resourceFile.ContentType, DisplayAlias="" };
                    _context.ResourceFiles.Add(resourceFileModel);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories.OrderBy(c => c.DisplayAlias), "Id", "DisplayAlias", photo.CategoryId);
            return View(photo);
        }

        // GET: Photos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos.FindAsync(id);
            if (photo == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories.OrderBy(c=>c.DisplayAlias), "Id", "DisplayAlias", photo.CategoryId);
            return View(photo);
        }

        // POST: Photos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("URL,Resolution,Size,Tags,CategoryId,Description,Id,DisplayAlias,Enabled")] Photo photo, IFormFile uploadedFile, IFormFile resourceFile)
        {
            if (id != photo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (uploadedFile != null)
                    {
                        string path = "/files/" + uploadedFile.FileName;
                        using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.OpenOrCreate))
                        {
                            await uploadedFile.CopyToAsync(fileStream);
                            photo.Size = (fileStream.Length / 1000).ToString();
                            var img = Image.FromStream(fileStream);
                            photo.Resolution = img.Width + " x " + img.Height;
                        }
                        photo.URL = path;
                    }
                    _context.Update(photo);
                    if (resourceFile != null)
                    {
                        string path = "/resourceFiles/" + resourceFile.FileName;
                        using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.OpenOrCreate))
                        {
                            await resourceFile.CopyToAsync(fileStream);
                        }
                        ResourceFile resourceFileModel = _context.ResourceFiles.FirstOrDefault(r => r.ResourceId == photo.Id);
                        if (resourceFileModel == null)
                        {
                            resourceFileModel = new ResourceFile() { Id = Guid.NewGuid(), Enabled = true, ResourceFilePath = path, ResourceId = photo.Id, ContentType = resourceFile.ContentType, DisplayAlias="" };
                            _context.ResourceFiles.Add(resourceFileModel);
                        }
                        else
                        {
                            resourceFileModel.ResourceFilePath = path;
                            resourceFileModel.ContentType = resourceFile.ContentType;
                            _context.ResourceFiles.Update(resourceFileModel);
                        }

                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhotoExists(photo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories.OrderBy(c => c.DisplayAlias), "Id", "DisplayAlias", photo.CategoryId);
            return View(photo);
        }

        // GET: Photos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (photo == null)
            {
                return NotFound();
            }

            return View(photo);
        }

        // POST: Photos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var photo = await _context.Photos.FindAsync(id);
            _context.Photos.Remove(photo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhotoExists(Guid id)
        {
            return _context.Photos.Any(e => e.Id == id);
        }
    }
}
