using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProgOdev.Data;
using WebProgOdev.Models;

namespace WebProgOdev.Controllers
{
    [Authorize(Roles = "admin")]
    public class DetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Details
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Texts.Include(t => t.CategoryTextProp).Include(t => t.MemberTextProp);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Details/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var text = await _context.Texts
                .Include(t => t.CategoryTextProp)
                .Include(t => t.MemberTextProp)
                .FirstOrDefaultAsync(m => m.yaziID == id);
            if (text == null)
            {
                return NotFound();
            }

            return View(text);
        }

        // GET: Details/Create
        public IActionResult Create()
        {
            ViewData["FKkategoriID"] = new SelectList(_context.Categories, "kategoriID", "kategoriID");
            ViewData["FKuyeID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("yaziID,yaziBaslik,yaziTarih,yaziIcerik,FKkategoriID,FKuyeID")] Text text)
        {
            if (ModelState.IsValid)
            {
                _context.Add(text);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FKkategoriID"] = new SelectList(_context.Categories, "kategoriID", "kategoriID", text.FKkategoriID);
            ViewData["FKuyeID"] = new SelectList(_context.Users, "Id", "Id", text.FKuyeID);
            return View(text);
        }

        // GET: Details/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var text = await _context.Texts.FindAsync(id);
            if (text == null)
            {
                return NotFound();
            }
            ViewData["FKkategoriID"] = new SelectList(_context.Categories, "kategoriID", "kategoriID", text.FKkategoriID);
            ViewData["FKuyeID"] = new SelectList(_context.Users, "Id", "Id", text.FKuyeID);
            return View(text);
        }

        // POST: Details/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("yaziID,yaziBaslik,yaziTarih,yaziIcerik,FKkategoriID,FKuyeID")] Text text)
        {
            if (id != text.yaziID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(text);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TextExists(text.yaziID))
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
            ViewData["FKkategoriID"] = new SelectList(_context.Categories, "kategoriID", "kategoriID", text.FKkategoriID);
            ViewData["FKuyeID"] = new SelectList(_context.Users, "Id", "Id", text.FKuyeID);
            return View(text);
        }

        // GET: Details/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var text = await _context.Texts
                .Include(t => t.CategoryTextProp)
                .Include(t => t.MemberTextProp)
                .FirstOrDefaultAsync(m => m.yaziID == id);
            if (text == null)
            {
                return NotFound();
            }

            return View(text);
        }

        // POST: Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var text = await _context.Texts.FindAsync(id);
            _context.Texts.Remove(text);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TextExists(int id)
        {
            return _context.Texts.Any(e => e.yaziID == id);
        }
    }
}
