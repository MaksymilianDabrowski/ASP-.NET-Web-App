using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Password_Keep.Models;

namespace Password_Keep.Controllers
{
    public class PasswordModelsController : Controller
    {
        private readonly PasswordDbContext _context;

        public PasswordModelsController(PasswordDbContext context)
        {
            _context = context;
        }

        // GET: PasswordModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Passwords.ToListAsync());
        }

        // GET: PasswordModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passwordModel = await _context.Passwords
                .FirstOrDefaultAsync(m => m.PasswordId == id);
            if (passwordModel == null)
            {
                return NotFound();
            }

            return View(passwordModel);
        }

        // GET: PasswordModels/AddOrEdit
        public IActionResult AddOrEdit()
        {
            return View(new PasswordModel());
        }

        // POST: PasswordModels/AddOrEdit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("PasswordId,PlatformName,StoredPassword")] PasswordModel passwordModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(passwordModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(passwordModel);
        }

        // GET: PasswordModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passwordModel = await _context.Passwords.FindAsync(id);
            if (passwordModel == null)
            {
                return NotFound();
            }
            return View(passwordModel);
        }

        // POST: PasswordModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PasswordId,PlatformName,StoredPassword")] PasswordModel passwordModel)
        {
            if (id != passwordModel.PasswordId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(passwordModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PasswordModelExists(passwordModel.PasswordId))
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
            return View(passwordModel);
        }

        // GET: PasswordModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passwordModel = await _context.Passwords
                .FirstOrDefaultAsync(m => m.PasswordId == id);
            if (passwordModel == null)
            {
                return NotFound();
            }

            return View(passwordModel);
        }

        // POST: PasswordModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var passwordModel = await _context.Passwords.FindAsync(id);
            _context.Passwords.Remove(passwordModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PasswordModelExists(int id)
        {
            return _context.Passwords.Any(e => e.PasswordId == id);
        }
    }
}
