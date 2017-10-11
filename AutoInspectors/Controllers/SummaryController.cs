using AutoInspectors.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AutoInspectors.Controllers
{
    public class SummaryController : Controller
    {
        private static readonly AutoInspectorsContext _context;

        /*var query = _context.Join(_context.Vehicle,
                vehicle => vehicle,
                inspection => inspection.VehicleID);*/
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}