using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FarmerSupport2.Models;

namespace FarmerSupport2.Controllers
{
    public class FarmerModelsController : Controller
    {
        private readonly FarmerSupport2Context _context;

        public FarmerModelsController(FarmerSupport2Context context)
        {
            _context = context;
        }

        // GET: FarmerModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.FarmerModel.ToListAsync());
        }

        // GET: FarmerModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmerModel = await _context.FarmerModel
                .FirstOrDefaultAsync(m => m.FarmerId == id);
            if (farmerModel == null)
            {
                return NotFound();
            }

            return View(farmerModel);
        }

        // GET: FarmerModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FarmerModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FarmerId,Sunlight,Temperature,Humidity,ElectricalConducitvity,Rainfall,Past3Months,Next3Months")] FarmerModel farmerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(farmerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(farmerModel);
        }

        // GET: FarmerModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmerModel = await _context.FarmerModel.FindAsync(id);
            if (farmerModel == null)
            {
                return NotFound();
            }
            return View(farmerModel);
        }

        // POST: FarmerModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FarmerId,Sunlight,Temperature,Humidity,ElectricalConducitvity,Rainfall,Past3Months,Next3Months")] FarmerModel farmerModel)
        {
            if (id != farmerModel.FarmerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(farmerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FarmerModelExists(farmerModel.FarmerId))
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
            return View(farmerModel);
        }

        // GET: FarmerModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmerModel = await _context.FarmerModel
                .FirstOrDefaultAsync(m => m.FarmerId == id);
            if (farmerModel == null)
            {
                return NotFound();
            }

            return View(farmerModel);
        }

        // POST: FarmerModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var farmerModel = await _context.FarmerModel.FindAsync(id);
            _context.FarmerModel.Remove(farmerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FarmerModelExists(int id)
        {
            return _context.FarmerModel.Any(e => e.FarmerId == id);
        }

        //data comparing and returing back 
       public ActionResult setCropInformation(int sunlight,int temperature,int humidity,int elecricalconductivity, int rainfall)
       {
            var cropInformationModel = _context.FarmerModel.FirstOrDefault(x => x.Sunlight == sunlight && x.Humidity == humidity
                                                                            && x.Rainfall == rainfall && x.Temperature == temperature
                                                                            && x.ElectricalConducitvity == elecricalconductivity);

            return Content("Crop Condition from past 3 months is : "+cropInformationModel.Next3Months+"           AND             Crop condition for next 3 months will be : "+cropInformationModel.Past3Months);
       }
    }
}
