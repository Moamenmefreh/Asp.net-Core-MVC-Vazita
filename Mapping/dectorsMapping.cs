using AutoMapper;
using Hayaat_Karima.dto;


namespace Hayaat_Karima.Mapping
{
    public class dectorsMapping:Profile
    {
        public dectorsMapping()
        {
            //CreateMap<decotdto, DoctorsTb>().ForPath(
            //    des=>des.SpecializatinTb.SpecializatinName,
            //    opt=>opt.MapFrom(src=>src.special)).ForPath(
            //    des => des.Region.RegionName,
            //    opt => opt.MapFrom(src => src.city)).ForMember(
            //    des => des.DocName,
            //    opt => opt.MapFrom(src => src.Name));
        }
    }
}
