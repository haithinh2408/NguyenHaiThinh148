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
    public class PersonNHT148Controller : Controller
    {
        private readonly NguyenHaiThinh148Context _context;

        public PersonNHT148Controller(NguyenHaiThinh148Context context)
        {
            _context = context;
        }

        // GET: PersonNHT148
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonNHT148.ToListAsync());
        }

        // GET: PersonNHT148/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNHT148 = await _context.PersonNHT148
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personNHT148 == null)
            {
                return NotFound();
            }

            return View(personNHT148);
        }

        // GET: PersonNHT148/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonNHT148/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,PersonName")] PersonNHT148 personNHT148)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personNHT148);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personNHT148);
        }

        // GET: PersonNHT148/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNHT148 = await _context.PersonNHT148.FindAsync(id);
            if (personNHT148 == null)
            {
                return NotFound();
            }
            return View(personNHT148);
        }

        // POST: PersonNHT148/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonID,PersonName")] PersonNHT148 personNHT148)
        {
            if (id != personNHT148.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNHT148);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNHT148Exists(personNHT148.PersonID))
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
            return View(personNHT148);
        }

        // GET: PersonNHT148/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNHT148 = await _context.PersonNHT148
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personNHT148 == null)
            {
                return NotFound();
            }

            return View(personNHT148);
        }

        // POST: PersonNHT148/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personNHT148 = await _context.PersonNHT148.FindAsync(id);
            _context.PersonNHT148.Remove(personNHT148);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNHT148Exists(string id)
        {
            return _context.PersonNHT148.Any(e => e.PersonID == id);
        }
    }
}
