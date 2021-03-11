using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CovidJournal.Data;
using CovidJournal.Models;

namespace CovidJournal.Controllers
{
    public class SymptomsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SymptomsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Symptoms
        public async Task<IActionResult> Index()
        {
            return View(await _context.Symptoms.ToListAsync());
        }

        // GET: Symptoms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var symptoms = await _context.Symptoms
                .FirstOrDefaultAsync(m => m.SymptomsId == id);
            if (symptoms == null)
            {
                return NotFound();
            }

            return View(symptoms);
        }

        // GET: Symptoms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Symptoms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SymptomsId,Headache,Cough,Lack_of_Smell,Lack_of_Taste,Fever,Chills,Breathlessness,Fatigue,Sore_Throat,Nausea,Diarrhea,Chest_Pressure,Pale_Blue_Skin")] Symptoms symptoms)
        {
            if (ModelState.IsValid)
            {
                _context.Add(symptoms);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(symptoms);
        }

        // GET: Symptoms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var symptoms = await _context.Symptoms.FindAsync(id);
            if (symptoms == null)
            {
                return NotFound();
            }
            return View(symptoms);
        }

        // POST: Symptoms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SymptomsId,Headache,Cough,Lack_of_Smell,Lack_of_Taste,Fever,Chills,Breathlessness,Fatigue,Sore_Throat,Nausea,Diarrhea,Chest_Pressure,Pale_Blue_Skin")] Symptoms symptoms)
        {
            if (id != symptoms.SymptomsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(symptoms);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SymptomsExists(symptoms.SymptomsId))
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
            return View(symptoms);
        }

        // GET: Symptoms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var symptoms = await _context.Symptoms
                .FirstOrDefaultAsync(m => m.SymptomsId == id);
            if (symptoms == null)
            {
                return NotFound();
            }

            return View(symptoms);
        }

        // POST: Symptoms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var symptoms = await _context.Symptoms.FindAsync(id);
            _context.Symptoms.Remove(symptoms);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SymptomsExists(int id)
        {
            return _context.Symptoms.Any(e => e.SymptomsId == id);
        }
    }
}
