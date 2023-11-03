#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using library_system.Models;

namespace library_system.Controllers
{
    public class GeneralBooksController : Controller
    {
        private readonly MyDbContext _context;

        public GeneralBooksController(MyDbContext context)
        {
            _context = context;
        }

        // GET: GeneralBooks
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.GeneralBook.Include(g => g.Catalog);
            return View(await myDbContext.ToListAsync());
        }

        // GET: GeneralBooks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalBook = await _context.GeneralBook
                .Include(g => g.Catalog)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalBook == null)
            {
                return NotFound();
            }

            return View(generalBook);
        }

        // GET: GeneralBooks/Create
        public IActionResult Create()
        {
            ViewData["CatalogId"] = new SelectList(_context.Catalog, "Id", "Id");
            return View();
        }

        // POST: GeneralBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AuthorName,BookName,CatalogId")] GeneralBook generalBook)
        {
            if (ModelState.IsValid)
            {
                _context.Add(generalBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CatalogId"] = new SelectList(_context.Catalog, "Id", "Id", generalBook.CatalogId);
            return View(generalBook);
        }

        // GET: GeneralBooks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalBook = await _context.GeneralBook.FindAsync(id);
            if (generalBook == null)
            {
                return NotFound();
            }
            ViewData["CatalogId"] = new SelectList(_context.Catalog, "Id", "Id", generalBook.CatalogId);
            return View(generalBook);
        }

        // POST: GeneralBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AuthorName,BookName,CatalogId")] GeneralBook generalBook)
        {
            if (id != generalBook.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generalBook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneralBookExists(generalBook.Id))
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
            ViewData["CatalogId"] = new SelectList(_context.Catalog, "Id", "Id", generalBook.CatalogId);
            return View(generalBook);
        }

        // GET: GeneralBooks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalBook = await _context.GeneralBook
                .Include(g => g.Catalog)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalBook == null)
            {
                return NotFound();
            }

            return View(generalBook);
        }

        // POST: GeneralBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var generalBook = await _context.GeneralBook.FindAsync(id);
            _context.GeneralBook.Remove(generalBook);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneralBookExists(int id)
        {
            return _context.GeneralBook.Any(e => e.Id == id);
        }
    }
}
