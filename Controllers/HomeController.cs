using Hayaat_Karima.Models;
using Hayaat_Karima.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Microsoft.IdentityModel.Tokens;
using AutoMapper;
using System.Linq;

namespace Hayaat_Karima.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        //private readonly IServices<DoctorsTb> _Iservices;
        private readonly AppDbContext _appContext;
        public HomeController(AppDbContext _appContext, IMapper mapper)
        {
            //  this._Iservices = _Iservices;
            this._appContext = _appContext;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
             IEnumerable<DoctorsTb> doctors = await _appContext.DoctorsTb.Include(x=>x.SpecializatinTb).Include(
                 s=>s.region).ToListAsync();

            return View(doctors);
        }

        public async Task<IActionResult> Detailsalldoctor(string specialName, string regionName ,string docName)
        {
            IEnumerable<DoctorsTb> query = _appContext.DoctorsTb.Include(x => x.SpecializatinTb).
                Include(x => x.region).Include(x => x.AppointmentTB)
                .ToList();
           

            if (specialName!=null)
            {
                query = query.Where(x => x.SpecializatinTb.SpecializatinName == specialName).ToList();
            }
            if(regionName!=null)
            {
                query = query.Where(x => x.region.RegionName == regionName).ToList();

            }
            if(docName!=null)
            {
                query = query.Where(x => x.DocName == docName).ToList();

            }
            return View(query);
        }
        //public async Task<IActionResult> Detailsalldoctor(DoctorsTb dto)
        //{
        //    var doctor = await _appContext.DoctorsTbs.ToListAsync();
        //    if(dto == null)
        //    {
        //        return View(doctor);

        //    }
        //    else
        //    {
        //        if(dto.SpecializatinTb.SpecializatinName != null)
        //        {
        //            doctor = await _appContext.DoctorsTbs.Where(x => x.SpecializationIdfk == dto.SpecializatinTb.SpecializatinIdpk).ToListAsync();

        //        }
        //        if(dto.Region.RegionName!= null)
        //        {
        //            doctor = await _appContext.DoctorsTbs.Where(x => x.regionId == dto.Region.PkregionId).ToListAsync();

        //        }
        //        return View(doctor);
        //    }
        //}

        //[HttpPost]
        //public IActionResult Detailsalldoctor(int specializationIdfk, string regionName, string docName)
        //{
        //    var doctors = _appContext.DoctorsTbs.AsQueryable();

        //    if (!string.IsNullOrEmpty(regionName))
        //        doctors = doctors.Where(d => d.Region.RegionName.Contains(regionName));

        //    if (!string.IsNullOrEmpty(docName))
        //        doctors = doctors.Where(d => d.DocName.Contains(docName));

        //    return View(doctors.ToList());
        //}

        //public async Task<IActionResult> Detailsalldoctor(DoctorsTb dto)
        //{



        //    var query = _appContext.DoctorsTbs.Include(x => x.SpecializatinTb)
        //                            .Include(x => x.Region);

        //    if (!string.IsNullOrEmpty(dto.DocName) ||
        //        dto.Region.RegionName != null ||
        //        dto.SpecializatinTb.SpecializatinName != null)
        //    {
        //        var que = query.Where(x => x.DocName == dto.DocName || x.Region.RegionName == dto.Region.RegionName || x.SpecializatinTb.SpecializatinName == dto.SpecializatinTb.SpecializatinName);
        //        return View(que);
        //    }
        //    else
        //    {
        //        return View(query);
        //    }
        //}

        //var doctors = await _appContext.DoctorsTbs.Include(x => x.SpecializatinTb).Include(x => x.Region)
        //.Where(x => x.DocName == dto.DocName ||
        //x.regionId == dto.Region.PkregionId ||
        //x.SpecializationIdfk == dto.SpecializatinTb.SpecializatinIdpk

        //)
        //.ToListAsync();

        //if (doctors == null)
        //{

        //    return View(doctors);
        //}
        //else
        //{

        //    return View(doctors);
        //}



    }
}
