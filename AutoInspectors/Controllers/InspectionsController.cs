using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutoInspectors.Models;
using System.IO;
using Newtonsoft.Json;


namespace AutoInspectors.Controllers
{
    public class InspectionsController : Controller
    {
        private readonly AutoInspectorsContext _context;

        List<string> inspectorList = ReadFile();

        public static List<string> ReadFile()
        {
            string inspectorData = @"data.txt";

            List<string> dataList = new List<string>();
            try
            {
                using (StreamReader r = new StreamReader(inspectorData))
                {

                    // Use while != null pattern for loop
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        dataList.Add(line);
                    }

                    return dataList;
                }
            }
            catch
            {
                // need to return something here.
                return dataList;
            }
        }


        public InspectionsController(AutoInspectorsContext context)
        {
            _context = context;

        }



        // GET: Inspections
        public async Task<IActionResult> Index()
        {
            return View(await _context.Inspection.ToListAsync());
        }

        // GET: Inspections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspection = await _context.Inspection
                .SingleOrDefaultAsync(m => m.InspectionID == id);
            if (inspection == null)
            {
                return NotFound();
            }

            return View(inspection);
        }

        // GET: Inspections/Create
        public IActionResult Create()
        {
            IQueryable < Vehicle > VehicleQuery = from v in _context.Vehicle select v;
            ViewBag.VehicleInfo = new SelectList(VehicleQuery, "VehicleID", "LicensePlate");

            ViewBag.InspectorList = new SelectList(inspectorList);
            return View();
        }

        // POST: Inspections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InspectionID,DTCCode,EngineOil,TransmissionFluid,CoolantLevel,CoolantPH,BrakeFluid,BatteryTest,AlternatorTest,AirFilter,Hoses,Wires,FrontBrakes,RearBrakes,TireRotation,VehicleID,Inspector")] Inspection inspection)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inspection);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inspection);
        }

        // GET: Inspections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspection = await _context.Inspection.SingleOrDefaultAsync(m => m.InspectionID == id);
            if (inspection == null)
            {
                return NotFound();
            }
            return View(inspection);
        }

        // POST: Inspections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InspectionID,DTCCode,EngineOil,TransmissionFluid,CoolantLevel,CoolantPH,BrakeFluid,BatteryTest,AlternatorTest,AirFilter,Hoses,Wires,FrontBrakes,RearBrakes,TireRotation,Inspector")] Inspection inspection)
        {
            if (id != inspection.InspectionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inspection);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InspectionExists(inspection.InspectionID))
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
            return View(inspection);
        }

        // GET: Inspections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspection = await _context.Inspection
                .SingleOrDefaultAsync(m => m.InspectionID == id);
            if (inspection == null)
            {
                return NotFound();
            }

            return View(inspection);
        }

        // POST: Inspections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inspection = await _context.Inspection.SingleOrDefaultAsync(m => m.InspectionID == id);
            _context.Inspection.Remove(inspection);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InspectionExists(int id)
        {
            return _context.Inspection.Any(e => e.InspectionID == id);
        }
    }
}
