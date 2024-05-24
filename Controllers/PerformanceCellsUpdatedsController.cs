using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Implement_Role_Based_Authorization.Data;
using Implement_Role_Based_Authorization.Models;

namespace Implement_Role_Based_Authorization.Controllers
{
    public class PerformanceCellsUpdatedsController : Controller
    {
        private readonly Implement_Role_Based_AuthorizationContext _context;

        public PerformanceCellsUpdatedsController(Implement_Role_Based_AuthorizationContext context)
        {
            _context = context;
        }

        // GET: PerformanceCellsUpdateds
        public async Task<IActionResult> Index()
        {
              return _context.PerformanceCellsUpdated != null ? 
                          View(await _context.PerformanceCellsUpdated.ToListAsync()) :
                          Problem("Entity set 'Implement_Role_Based_AuthorizationContext.PerformanceCellsUpdated'  is null.");
        }

        // GET: PerformanceCellsUpdateds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PerformanceCellsUpdated == null)
            {
                return NotFound();
            }

            var performanceCellsUpdated = await _context.PerformanceCellsUpdated
                .FirstOrDefaultAsync(m => m.Pckey == id);
            if (performanceCellsUpdated == null)
            {
                return NotFound();
            }

            return View(performanceCellsUpdated);
        }

        // GET: PerformanceCellsUpdateds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PerformanceCellsUpdateds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PerformanceCell,SubPerformanceCell,SubSubPerformanceCell,Division,Subdivision,Department,Partner,Class,Scheme,Company,BusinessUnit,Years,Splits,Pckey,ModifiedDate,ModifiedUser,SubDivisionExclude,DepartmentExclude,PartnerExclude,ClassExclude,SchemeExclude")] PerformanceCellsUpdated performanceCellsUpdated)
        {
            if (ModelState.IsValid)
            {
                _context.Add(performanceCellsUpdated);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(performanceCellsUpdated);
        }

        // GET: PerformanceCellsUpdateds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PerformanceCellsUpdated == null)
            {
                return NotFound();
            }

            var performanceCellsUpdated = await _context.PerformanceCellsUpdated.FindAsync(id);
            if (performanceCellsUpdated == null)
            {
                return NotFound();
            }
            return View(performanceCellsUpdated);
        }

        // POST: PerformanceCellsUpdateds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PerformanceCell,SubPerformanceCell,SubSubPerformanceCell,Division,Subdivision,Department,Partner,Class,Scheme,Company,BusinessUnit,Years,Splits,Pckey,ModifiedDate,ModifiedUser,SubDivisionExclude,DepartmentExclude,PartnerExclude,ClassExclude,SchemeExclude")] PerformanceCellsUpdated performanceCellsUpdated)
        {
            if (id != performanceCellsUpdated.Pckey)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(performanceCellsUpdated);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerformanceCellsUpdatedExists(performanceCellsUpdated.Pckey))
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
            return View(performanceCellsUpdated);
        }

        // GET: PerformanceCellsUpdateds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PerformanceCellsUpdated == null)
            {
                return NotFound();
            }

            var performanceCellsUpdated = await _context.PerformanceCellsUpdated
                .FirstOrDefaultAsync(m => m.Pckey == id);
            if (performanceCellsUpdated == null)
            {
                return NotFound();
            }

            return View(performanceCellsUpdated);
        }

        // POST: PerformanceCellsUpdateds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PerformanceCellsUpdated == null)
            {
                return Problem("Entity set 'Implement_Role_Based_AuthorizationContext.PerformanceCellsUpdated'  is null.");
            }
            var performanceCellsUpdated = await _context.PerformanceCellsUpdated.FindAsync(id);
            if (performanceCellsUpdated != null)
            {
                _context.PerformanceCellsUpdated.Remove(performanceCellsUpdated);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerformanceCellsUpdatedExists(int id)
        {
          return (_context.PerformanceCellsUpdated?.Any(e => e.Pckey == id)).GetValueOrDefault();
        }
    }
}
