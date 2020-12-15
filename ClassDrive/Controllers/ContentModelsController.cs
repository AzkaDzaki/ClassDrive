using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClassDrive.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace ClassDrive.Controllers
{
    public class ContentModelsController : Controller
    {
        private readonly DriveDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ContentModelsController(DriveDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }
        [Authorize(Roles = "Admin")]

        // GET: ContentModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContentModel.ToListAsync());

        }

        public async Task<IActionResult> ContentList(int courseId)
        {
            var contentModel = _context.ContentModel.Where(x => x.CourseID == courseId).ToList();
            ViewBag.ContentList = await _context.CourseModel
                .FirstOrDefaultAsync(m => m.CourseID == courseId);
            return View(contentModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // GET: ContentModels/Create
        public IActionResult CreateContent(int courseId)
        {
            ViewBag.CreateContent = courseId;
            return View();
        }
        [Authorize(Roles = "Admin,Dosen")]

        // POST: ContentModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateContent([Bind("ContentID,CourseID,ContentName,ContentFile")] ContentModel contentModel)
        {
            if (ModelState.IsValid)
            {
                //Save to File
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(contentModel.ContentFile.FileName);
                string extension = Path.GetExtension(contentModel.ContentFile.FileName);
                contentModel.ContentDescription = fileName = fileName + extension;
                //contentModel.ContentDescription = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                string path = Path.Combine(wwwRootPath + "/File", fileName);
                using(var fileStream = new FileStream(path, FileMode.Create))
                {
                    await contentModel.ContentFile.CopyToAsync(fileStream);
                }
                //Insert record
                _context.Add(contentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("ContentList", new { courseID = contentModel.CourseID });
            }
            return View(contentModel);
        }

        public async Task<IActionResult> Download(string filename)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/File", filename);
            var memory = new MemoryStream();
            using(var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }

            memory.Position = 0;
            return File(memory, "image/*", filename);

            //string wwwRootPath = _hostEnvironment.WebRootPath;
            //var contentModel =await _context.ContentModel
            //    .FirstOrDefaultAsync(m => m.ContentID == id);
            //string filePath = Path.Combine(wwwRootPath + "/File", contentModel.ContentDescription);
            //string fileName = contentModel.ContentDescription;
            //byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);

            //return File(fileBytes, "image/*", fileName);
        }

        // GET: ContentModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentModel = await _context.ContentModel
                .FirstOrDefaultAsync(m => m.ContentID == id);
            if (contentModel == null)
            {
                return NotFound();
            }

            return View(contentModel);
        }

        // GET: ContentModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContentModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContentID,CourseID,ContentName,ContentDescription")] ContentModel contentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contentModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // GET: ContentModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentModel = await _context.ContentModel.FindAsync(id);
            if (contentModel == null)
            {
                return NotFound();
            }
            return View(contentModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // POST: ContentModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContentID,CourseID,ContentName,ContentDescription")] ContentModel contentModel)
        {
            if (id != contentModel.ContentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContentModelExists(contentModel.ContentID))
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
            return View(contentModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // GET: ContentModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentModel = await _context.ContentModel
                .FirstOrDefaultAsync(m => m.ContentID == id);
            if (contentModel == null)
            {
                return NotFound();
            }

            return View(contentModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // POST: ContentModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contentModel = await _context.ContentModel.FindAsync(id);

            //delete image from File
            var filePath = Path.Combine(_hostEnvironment.WebRootPath, "file", contentModel.ContentDescription);
            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);

            _context.ContentModel.Remove(contentModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("ContentList", new { courseID = contentModel.CourseID });
        }

        private bool ContentModelExists(int id)
        {
            return _context.ContentModel.Any(e => e.ContentID == id);
        }
    }
}
