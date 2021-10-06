using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenHaiThinh148.Data;
using NguyenHaiThinh148.Models;

namespace NguyenHaiThinh148.Controllers
{
    public class NHT0148Controller : Controller
    {
        private readonly NguyenHaiThinh148Context _context;

        public NHT0148Controller(NguyenHaiThinh148Context context)
        {
            _context = context;
        }

        // GET: NHT0148
        public async Task<IActionResult> Index()
        {
            return View(await _context.NHT0148.ToListAsync());
        }

        // GET: NHT0148/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nHT0148 = await _context.NHT0148
                .FirstOrDefaultAsync(m => m.NHTId == id);
            if (nHT0148 == null)
            {
                return NotFound();
            }

            return View(nHT0148);
        }

        // GET: NHT0148/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NHT0148/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NHTId,NHTName,NHTGender")] NHT0148 nHT0148)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nHT0148);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nHT0148);
        }

        // GET: NHT0148/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nHT0148 = await _context.NHT0148.FindAsync(id);
            if (nHT0148 == null)
            {
                return NotFound();
            }
            return View(nHT0148);
        }

        // POST: NHT0148/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NHTId,NHTName,NHTGender")] NHT0148 nHT0148)
        {
            if (id != nHT0148.NHTId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nHT0148);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NHT0148Exists(nHT0148.NHTId))
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
            return View(nHT0148);
        }

        // GET: NHT0148/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nHT0148 = await _context.NHT0148
                .FirstOrDefaultAsync(m => m.NHTId == id);
            if (nHT0148 == null)
            {
                return NotFound();
            }

            return View(nHT0148);
        }

        // POST: NHT0148/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nHT0148 = await _context.NHT0148.FindAsync(id);
            _context.NHT0148.Remove(nHT0148);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NHT0148Exists(string id)
        {
            return _context.NHT0148.Any(e => e.NHTId == id);
        }
    }
}
