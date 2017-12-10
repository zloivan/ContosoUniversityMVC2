using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContosoUniversityMVC2.Models;
using ContosoUniversityMVC2.Models.SchoolViewModels;
using ContosoUniversityMVC2.Data;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversityMVC2.Controllers
{
    public class HomeController : Controller
    {
        private readonly SchoolContext _context;
        public HomeController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            IQueryable<EnrollmentDateGroup> data = _context.Students
                .GroupBy(s => s.EnrollmentDate)
                .Select(e => new EnrollmentDateGroup
                {
                    EnrollmentDate = e.Key,
                    StudentCount = e.Count()
                });

            return View(await data.AsNoTracking().ToListAsync());
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
