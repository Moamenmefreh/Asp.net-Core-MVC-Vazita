//using Hayaat_Karima.Data;
//using Hayaat_Karima.dto;
//using Hayaat_Karima.IRepository;
//using Hayaat_Karima.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using System.Collections;

//namespace Hayaat_Karima.Repository
//{
   
//    public class Services<T> :IServices<T> where T : class
//    {
//        private readonly AppDbContext appDbContext;

//        public Services(AppDbContext _appDbContext)
//        {
//            this.appDbContext = _appDbContext;
//        }

//        //public async Task<IEnumerable<DoctorsTb>> All()
//        //{
//        //    IEnumerable<DoctorsTb> AllDecotors1 = await appDbContext.DoctorsTbs.ToListAsync();
//        //    return AllDecotors1;
//            //if (dto.special != null)
//            //{
//            //    IEnumerable<DoctorsTb> AllDecotors =await appDbContext.DoctorsTbs.Where(x => x.SpecializationIdfk == dto.special).Select(x => 
//            //        new DoctorsTb { DocIdpk= dto.special,
//            //        DocName = dto.Name,
//            //        SpecializationIdfk = dto.special
//            //        }).ToListAsync();
//            //    return AllDecotors;
//            //}
//            //if(dto.Name != null)
//            //{
//            //    IEnumerable<DoctorsTb> AllDecotors =await appDbContext.DoctorsTbs.Where(x => x.DocName == dto.Name).Select(x =>
//            //        new DoctorsTb
//            //        {
//            //            DocIdpk = dto.special,
//            //            DocName = dto.Name,
//            //            SpecializationIdfk = dto.special
//            //        }).ToListAsync();
//            //    return AllDecotors;
//            //}
//            //else
//            //{
//            //    IEnumerable<DoctorsTb> AllDecotors = await appDbContext.DoctorsTbs.ToListAsync();
//            //    return AllDecotors;
//            //}
          
//       // }
       
//        //public async Task<IEnumerable<DoctorsTb>> detailsAlldoctor(DoctorsTb dto)
//        //{
           
            
//        //}

//        //public async Task<IEnumerable<DoctorsTb>> detailsAlldoctor(DoctorsTb dto) { 
//        ////{
//        ////    var detailsAlldoctor = await appDbContext.DoctorsTbs
//        ////         .Where(x => x.SpecializationIdfk == dto.SpecializatinTb.SpecializatinIdpk
//        ////         || x.DocName == dto.DocName ||
//        ////         x.TechnicalLevel == dto.TechnicalLevel
//        ////         ).ToListAsync();

//        //    return View();
//        //}

//        public async Task<IEnumerable<DoctorsTb>>All()
//        {
//            IEnumerable<DoctorsTb> AllDecotors1 = await appDbContext.DoctorsTbs.ToListAsync();
//            return AllDecotors1;
//        }


//    }
//}
