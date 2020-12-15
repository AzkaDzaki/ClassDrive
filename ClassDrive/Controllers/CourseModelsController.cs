using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClassDrive.Models;
using Microsoft.AspNetCore.Authorization;

namespace ClassDrive.Controllers
{
    public class CourseModelsController : Controller
    {
        private readonly DriveDbContext _context;

        public CourseModelsController(DriveDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin, Dosen, Mahasiswa")]

        // GET: CourseModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourseModel.ToListAsync());
        }

        // GET: CourseModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseModel = await _context.CourseModel
                .FirstOrDefaultAsync(m => m.CourseID == id);

            if (courseModel == null)
            {
                return NotFound();
            }

            return View(courseModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // GET: CourseModels/Create
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin,Dosen")]

        // POST: CourseModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseID,CourseName,CourseDescription,CourseSchedule,CourseTeacher")] CourseModel courseModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // GET: CourseModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseModel = await _context.CourseModel.FindAsync(id);
            if (courseModel == null)
            {
                return NotFound();
            }
            return View(courseModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // POST: CourseModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseID,CourseName,CourseDescription,CourseSchedule,CourseTeacher")] CourseModel courseModel)
        {
            if (id != courseModel.CourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseModelExists(courseModel.CourseID))
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
            return View(courseModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // GET: CourseModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseModel = await _context.CourseModel
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (courseModel == null)
            {
                return NotFound();
            }

            return View(courseModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // POST: CourseModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseModel = await _context.CourseModel.FindAsync(id);
            _context.CourseModel.Remove(courseModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseModelExists(int id)
        {
            return _context.CourseModel.Any(e => e.CourseID == id);
        }
    }
}
