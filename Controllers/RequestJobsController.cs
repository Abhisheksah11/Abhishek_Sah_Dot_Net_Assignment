using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Abhishek_Sah_Dot_Net_Assignment.Data;
using Abhishek_Sah_Dot_Net_Assignment.Models;

namespace Abhishek_Sah_Dot_Net_Assignment.Controllers
{
    public class RequestJobsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RequestJobsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RequestJobs
        public async Task<IActionResult> Index()
        {
            return View(await _context.RequestJob.ToListAsync());
        }

        // GET: RequestJobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestJob = await _context.RequestJob
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requestJob == null)
            {
                return NotFound();
            }

            return View(requestJob);
        }

        // GET: RequestJobs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RequestJobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmployeeId,JobTitle,RequestedDate,Remarks")] RequestJob requestJob)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requestJob);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requestJob);
        }

        // GET: RequestJobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestJob = await _context.RequestJob.FindAsync(id);
            if (requestJob == null)
            {
                return NotFound();
            }
            return View(requestJob);
        }

        // POST: RequestJobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EmployeeId,JobTitle,RequestedDate,Remarks")] RequestJob requestJob)
        {
            if (id != requestJob.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requestJob);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequestJobExists(requestJob.Id))
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
            return View(requestJob);
        }

        // GET: RequestJobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestJob = await _context.RequestJob
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requestJob == null)
            {
                return NotFound();
            }

            return View(requestJob);
        }

        // POST: RequestJobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var requestJob = await _context.RequestJob.FindAsync(id);
            if (requestJob != null)
            {
                _context.RequestJob.Remove(requestJob);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequestJobExists(int id)
        {
            return _context.RequestJob.Any(e => e.Id == id);
        }
    }
}
