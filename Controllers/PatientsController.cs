using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia12.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia12.Controllers
{
    public class PatientsController : Controller
    {
        private readonly s18844Context _context;
        public PatientsController(s18844Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var db = new s18844Context();
            var patients = db.Patient.ToList();
            return View(patients);
        }

        public string GetDoctors()
        {
            return "AKA";
        }

        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return View(patient);
            }
            var db = new s18844Context();
            db.Patient.Add(patient);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}