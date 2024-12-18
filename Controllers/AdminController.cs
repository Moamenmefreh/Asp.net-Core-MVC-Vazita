using Hayaat_Karima.Data;
using Hayaat_Karima.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hayaat_Karima.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult AllDoctors()
        {
            IEnumerable<DoctorsTb> doctors = _context.DoctorsTb.Include(e=>e.SpecializatinTb).Include(x=>x.region).ToList();
            return View("AllDoctors",doctors);
        }
        public IActionResult AddNewDoctor()
        {
           
            ViewData["Specialization"] = _context.SpecializatinTbs.ToList();
            ViewData["Region"] = _context.Regions.ToList();
            return View("AddNewDoctor");
        }
        [HttpPost]
        public IActionResult SaveNewDoctor(DoctorsTb doc)
        {
            if (ModelState.IsValid==false)
            {
                return View("AddNewDoctor");
            }
            else
            {
                _context.DoctorsTb.Add(doc);
                _context.SaveChanges();
                return RedirectToAction("AllDoctors");
            }
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var doctor=_context.DoctorsTb.SingleOrDefault(x=>x.DocIdpk==id);
            
            ViewData["Specialization"] = _context.SpecializatinTbs.ToList();
            ViewData["Region"] = _context.Regions.ToList();
            return View("Update",doctor);
        }
        [HttpPost]
        public IActionResult SaveUpdate(DoctorsTb doc)
        {
            var doctor = _context.DoctorsTb.SingleOrDefault(x => x.DocIdpk == doc.DocIdpk);

            if (ModelState.IsValid == true)
            {
                doctor.DocName = doc.DocName;
                doctor.DocPhone = doc.DocPhone;
                doctor.DocPhoto = doc.DocPhoto;
                doctor.NumberOfcasesMonthly = doc.NumberOfcasesMonthly;
                doctor.RegionId = doc.RegionId;
                doctor.SpecializationIdfk = doc.SpecializationIdfk;
                _context.Update(doctor);
                _context.SaveChanges();
                return RedirectToAction("AllDoctors");
            }
            else
            {
                return View("Update", doctor);
            }
            
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var doctor = _context.DoctorsTb.SingleOrDefault(x => x.DocIdpk == id);
            ViewData["Specialization"] = _context.SpecializatinTbs.ToList();
            ViewData["Region"] = _context.Regions.ToList();
            return View("Delete", doctor);
        }
        [HttpPost]
        public IActionResult SaveDelete(DoctorsTb doc)
        {
            var doctor = _context.DoctorsTb.SingleOrDefault(x => x.DocIdpk == doc.DocIdpk);

            _context.DoctorsTb.Remove(doctor);
            _context.SaveChanges();
            return RedirectToAction("AllDoctors");
        }
    }
}
