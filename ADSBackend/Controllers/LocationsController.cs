using ADSBackend.Data;
using ADSBackend.Models.AccountViewModels;
using ADSBackend.Models.Identity;
using ADSBackend.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace ADSBackend.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class LocationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LocationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LocationsViewModels
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Locations.ToListAsync());
        }

        // GET: LocationsViewModels/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationsViewModel = await _context.Locations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locationsViewModel == null)
            {
                return NotFound();
            }

            return View(locationsViewModel);
        }

        // GET: LocationsViewModels/Create
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }

        // POST: LocationsViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Title,Latitude,Longitude,PhoneNumber,Address")] Locations locationsViewModel)
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

            var locationsViewModel = await _context.Locations.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Title,Latitude,Longitude,PhoneNumber,Address")] Locations locationsViewModel)
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

            var locationsViewModel = await _context.Locations
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
            var locationsViewModel = await _context.Locations.FindAsync(id);
            _context.Locations.Remove(locationsViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationsViewModelExists(int id)
        {
            return _context.Locations.Any(e => e.Id == id);
        }


        [HttpGet]
        [Route("api/test")]
        public string TestMethod()
        {
            return "Check";
        }

    }
}
