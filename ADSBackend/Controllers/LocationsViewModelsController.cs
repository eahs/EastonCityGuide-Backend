using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ADSBackend.Models;
using ADSBackend.Models.AdminViewModels;

namespace ADSBackend.Controllers
{
    public class LocationsViewModelsController : Controller
    {
        private readonly ADSBackendContext _context;

        public LocationsViewModelsController(ADSBackendContext context)
        {
            _context = context;
        }

        // GET: LocationsViewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.LocationsViewModel.ToListAsync());
        }

        // GET: LocationsViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationsViewModel = await _context.LocationsViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locationsViewModel == null)
            {
                return NotFound();
            }

            return View(locationsViewModel);
        }

        // GET: LocationsViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LocationsViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Title,Latitude,Longitude,PhoneNumber,Address")] LocationsViewModel locationsViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locationsViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locationsViewModel);
        }

        // GET: LocationsViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationsViewModel = await _context.LocationsViewModel.FindAsync(id);
            if (locationsViewModel == null)
            {
                return NotFound();
            }
            return View(locationsViewModel);
        }

        // POST: LocationsViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Title,Latitude,Longitude,PhoneNumber,Address")] LocationsViewModel locationsViewModel)
        {
            if (id != locationsViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locationsViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationsViewModelExists(locationsViewModel.Id))
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
            return View(locationsViewModel);
        }

        // GET: LocationsViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationsViewModel = await _context.LocationsViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locationsViewModel == null)
            {
                return NotFound();
            }

            return View(locationsViewModel);
        }

        // POST: LocationsViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locationsViewModel = await _context.LocationsViewModel.FindAsync(id);
            _context.LocationsViewModel.Remove(locationsViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationsViewModelExists(int id)
        {
            return _context.LocationsViewModel.Any(e => e.Id == id);
        }
    }
}
