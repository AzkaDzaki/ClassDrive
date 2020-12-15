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
    public class TaskModelsController : Controller
    {
        private readonly DriveDbContext _context;

        public TaskModelsController(DriveDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin, Dosen, Mahasiswa")]

        // GET: TaskModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.TaskModel.ToListAsync());
        }

        // GET: TaskModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskModel = await _context.TaskModel
                .FirstOrDefaultAsync(m => m.TaskID == id);
            if (taskModel == null)
            {
                return NotFound();
            }

            return View(taskModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // GET: TaskModels/Create
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin,Dosen")]

        // POST: TaskModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskID,TaskName,TaskDescription,TaskDeadline,TaskCourse,TaskTeacher")] TaskModel taskModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taskModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // GET: TaskModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskModel = await _context.TaskModel.FindAsync(id);
            if (taskModel == null)
            {
                return NotFound();
            }
            return View(taskModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // POST: TaskModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskID,TaskName,TaskDescription,TaskDeadline,TaskCourse,TaskTeacher")] TaskModel taskModel)
        {
            if (id != taskModel.TaskID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskModelExists(taskModel.TaskID))
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
            return View(taskModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // GET: TaskModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskModel = await _context.TaskModel
                .FirstOrDefaultAsync(m => m.TaskID == id);
            if (taskModel == null)
            {
                return NotFound();
            }

            return View(taskModel);
        }
        [Authorize(Roles = "Admin,Dosen")]

        // POST: TaskModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taskModel = await _context.TaskModel.FindAsync(id);
            _context.TaskModel.Remove(taskModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskModelExists(int id)
        {
            return _context.TaskModel.Any(e => e.TaskID == id);
        }
    }
}
