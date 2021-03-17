using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CovidJournal.Data;
using CovidJournal.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace CovidJournal.Controllers
{
    [Authorize]
    public class CovidEntriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CovidEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CovidEntries
        public async Task<IActionResult> Index()
        {

            // Temperature graph
            List<DataPoint> temperatureList = new List<DataPoint>();
            List<DataPoint> moodList = new List<DataPoint>();

            var sortedEntryByDate = _context.CovidEntry.OrderByDescending(c=>c.Date).ToList();

            foreach (var item in sortedEntryByDate)
            {
                // converting datetime into javascript date
                var JSUnixDate = new DateTime(1970, 1, 1);
                var dateOfEntry = item.Date;
                var date = dateOfEntry.Subtract(JSUnixDate).TotalMilliseconds;
                
                // fill lists
                temperatureList.Add(new DataPoint(date, (double)item.Temperature));
                moodList.Add(new DataPoint(date, (double)item.Mood));
            }

            // serialize into json and pass into Bag for view to accept
            ViewBag.temperatureData = JsonConvert.SerializeObject(temperatureList);
            ViewBag.moodData = JsonConvert.SerializeObject(moodList);

            // Obtaining user data
            ViewBag.CurrentUser = GetCurrentUser();

            return View(await _context.CovidEntry.ToListAsync());
        }

        // Helper function to get user
        public ApplicationUser GetCurrentUser()
        {
            // user name of currently logged in user
            var userNameOfCurrentlyLoggedInUser = User.Identity.Name;

            // find in user table and get all details
            var user = _context.Users.Where(u => u.UserName == userNameOfCurrentlyLoggedInUser);
           
            return user.FirstOrDefault();
        }

        // GET: CovidEntries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var covidEntry = await _context.CovidEntry
                .FirstOrDefaultAsync(m => m.EntryId == id);
            if (covidEntry == null)
            {
                return NotFound();
            }

            return View(covidEntry);
        }

        // GET: CovidEntries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CovidEntries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EntryId,Date,Temperature,Note,Mood,Headache,Cough,Lack_of_Smell,Lack_of_Taste,Fever,Chills,Breathlessness,Fatigue,Sore_Throat,Nausea,Diarrhea,Chest_Pressure,Pale_Blue_Skin")] CovidEntry covidEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(covidEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(covidEntry);
        }

        // GET: CovidEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var covidEntry = await _context.CovidEntry.FindAsync(id);
            if (covidEntry == null)
            {
                return NotFound();
            }
            return View(covidEntry);
        }

        // POST: CovidEntries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EntryId,Date,Temperature,Note,Mood,Headache,Cough,Lack_of_Smell,Lack_of_Taste,Fever,Chills,Breathlessness,Fatigue,Sore_Throat,Nausea,Diarrhea,Chest_Pressure,Pale_Blue_Skin")] CovidEntry covidEntry)
        {
            if (id != covidEntry.EntryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(covidEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CovidEntryExists(covidEntry.EntryId))
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
            return View(covidEntry);
        }

        // GET: CovidEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var covidEntry = await _context.CovidEntry
                .FirstOrDefaultAsync(m => m.EntryId == id);
            if (covidEntry == null)
            {
                return NotFound();
            }

            return View(covidEntry);
        }

        // POST: CovidEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var covidEntry = await _context.CovidEntry.FindAsync(id);
            _context.CovidEntry.Remove(covidEntry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CovidEntryExists(int id)
        {
            return _context.CovidEntry.Any(e => e.EntryId == id);
        }
    }
}
