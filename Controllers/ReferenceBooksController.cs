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
    public class ReferenceBooksController : Controller
    {
        private readonly MyDbContext _context;

        public ReferenceBooksController(MyDbContext context)
        {
            _context = context;
        }

        // GET: ReferenceBooks
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.ReferenceBook.Include(r => r.Catalog);
            return View(await myDbContext.ToListAsync());
        }

        // GET: ReferenceBooks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referenceBook = await _context.ReferenceBook
                .Include(r => r.Catalog)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (referenceBook == null)
            {
                return NotFound();
            }

            return View(referenceBook);
        }

        // GET: ReferenceBooks/Create
        public IActionResult Create()
        {
            ViewData["CatalogId"] = new SelectList(_context.Catalog, "Id", "Id");
            return View();
        }

        // POST: ReferenceBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ISBN,Category,IsAvailableForReference,Id,AuthorName,BookName,CatalogId")] ReferenceBook referenceBook)
        {
         
                _context.Add(referenceBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
           
        }

        // GET: ReferenceBooks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referenceBook = await _context.ReferenceBook.FindAsync(id);
            if (referenceBook == null)
            {
                return NotFound();
            }
            ViewData["CatalogId"] = new SelectList(_context.Catalog, "Id", "Id", referenceBook.CatalogId);
            return View(referenceBook);
        }

        // POST: ReferenceBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ISBN,Category,IsAvailableForReference,Id,AuthorName,BookName,CatalogId")] ReferenceBook referenceBook)
        {
            if (id != referenceBook.Id)
            {
                return NotFound();
            }

           
                try
                {
                    _context.Update(referenceBook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReferenceBookExists(referenceBook.Id))
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

        // GET: ReferenceBooks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referenceBook = await _context.ReferenceBook
                .Include(r => r.Catalog)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (referenceBook == null)
            {
                return NotFound();
            }

            return View(referenceBook);
        }

        // POST: ReferenceBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var referenceBook = await _context.ReferenceBook.FindAsync(id);
            _context.ReferenceBook.Remove(referenceBook);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReferenceBookExists(int id)
        {
            return _context.ReferenceBook.Any(e => e.Id == id);
        }
    }
}
