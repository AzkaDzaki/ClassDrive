using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClassDrive.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace ClassDrive.Controllers
{
    public class SubmitModelsController : Controller
    {
        private readonly DriveDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;


        public SubmitModelsController(DriveDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;

        }
        [Authorize(Roles = "Admin")]

        // GET: SubmitModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.SubmitModel.ToListAsync());
        }


        public async Task<IActionResult> SubmitList(int taskId)
        {
            var submitModel = _context.SubmitModel.Where(x => x.TaskID == taskId).ToList();
            ViewBag.SubmitList = await _context.TaskModel
                .FirstOrDefaultAsync(m => m.TaskID == taskId);
            return View(submitModel);
        }
        [Authorize(Roles = "Admin,Mahasiswa")]

        // GET: ContentModels/Create
        public IActionResult CreateSubmit(int taskId)
        {
            ViewBag.CreateSubmit = taskId;
            return View();
        }
        [Authorize(Roles = "Admin,Mahasiswa")]

        // POST: ContentModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSubmit([Bind("SubmitID,TaskID,SubmitName,ContentFile,SubmitTime,SubmitScore")] SubmitModel submitModel)
        {
            if (ModelState.IsValid)
            {
                //Save to File
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(submitModel.ContentFile.FileName);
                string extension = Path.GetExtension(submitModel.ContentFile.FileName);
                //contentModel.ContentDescription = fileName = fileName + DateTime.Now.ToString("yymmssffff") + extension;
                submitModel.SubmitDescription = fileName = fileName + extension;
                submitModel.SubmitTime = DateTime.Now.ToString("dd MMMM yyyy");
                string path = Path.Combine(wwwRootPath + "/File", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await submitModel.ContentFile.CopyToAsync(fileStream);
                }
                //Insert record
                _context.Add(submitModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("SubmitList", new { TaskID = submitModel.TaskID });
            }
            return View(submitModel);
        }

        public async Task<IActionResult> Download(string filename)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/File", filename);
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
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

        // GET: SubmitModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submitModel = await _context.SubmitModel
                .FirstOrDefaultAsync(m => m.SubmitID == id);
            if (submitModel == null)
            {
                return NotFound();
            }

            return View(submitModel);
        }

        // GET: SubmitModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SubmitModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubmitID,TaskID,SubmitName,SubmitDescription,SubmitTime,SubmitScore")] SubmitModel submitModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(submitModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(submitModel);
        }
        [Authorize(Roles = "Admin, Dosen")]

        // GET: SubmitModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submitModel = await _context.SubmitModel.FindAsync(id);
            if (submitModel == null)
            {
                return NotFound();
            }
            return View(submitModel);
        }
        [Authorize(Roles = "Admin, Dosen")]

        // POST: SubmitModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubmitID,TaskID,SubmitName,SubmitDescription,SubmitTime,SubmitScore")] SubmitModel submitModel)
        {
            if (id != submitModel.SubmitID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(submitModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubmitModelExists(submitModel.SubmitID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("SubmitList", new { TaskID = submitModel.TaskID } );
            }
            return View(submitModel);
        }
        [Authorize(Roles = "Admin,Mahasiswa")]

        // GET: SubmitModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submitModel = await _context.SubmitModel
                .FirstOrDefaultAsync(m => m.SubmitID == id);
            if (submitModel == null)
            {
                return NotFound();
            }

            return View(submitModel);
        }
        [Authorize(Roles = "Admin,Mahasiswa")]

        // POST: SubmitModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var submitModel = await _context.SubmitModel.FindAsync(id);

            //delete image from File
            var filePath = Path.Combine(_hostEnvironment.WebRootPath, "file", submitModel.SubmitDescription);
            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);

            _context.SubmitModel.Remove(submitModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("SubmitList", new { TaskID = submitModel.TaskID });
        }

        private bool SubmitModelExists(int id)
        {
            return _context.SubmitModel.Any(e => e.SubmitID == id);
        }
    }
}
