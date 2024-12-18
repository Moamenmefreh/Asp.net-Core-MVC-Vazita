using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hayaat_Karima.Models
{
    public class AppointmentTB
    {
        [ForeignKey(nameof(DoctorsTb)),Key]
        public int? DocIDfk { get; set; }
        public int? MCIDfk { get; set; }
        public string? AppointmentDayDate1 { get; set; }
        public string? AppointmentDayDate2 { get; set; }
        public string? AppointmentDayDate3 { get; set; }
        public string? AppointmentDayDate4 { get; set; }
        public string? AppointmentDayDate5 { get; set; }
        public string? AppointmentDayDate6 { get; set; }
        public string? AppointmentDayDate7 { get; set; }
        public IEnumerable<DoctorsTb>? Doctor { get; set; }

    }
}
