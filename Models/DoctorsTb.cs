using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hayaat_Karima.Models;

[Table("DoctorsTB")]
public class DoctorsTb
{
    [Key]
    [Column("DocIDPK")]
    [Display(Name ="الرقم التسلسلي")]
    [Required(ErrorMessage ="ادخل الرقم التسلسلي")]
    public int DocIdpk { get; set; }

    [StringLength(50)]
    [Display(Name ="الدكتور")]
   [Required(ErrorMessage ="من فضلك ادخل اسم الدكتور")]
    public string DocName { get; set; }

    [StringLength(50)]

    public string? TechnicalLevel { get; set; }

    [Column("specializationIDFK"),ForeignKey(nameof(SpecializatinTb))]
   [Required(ErrorMessage ="ادخل تخصصك")]
    public int SpecializationIdfk { get; set; }

    [Column("NumberOFCasesMonthly")]
   [Required(ErrorMessage =" ادخل الحالات التي تريد انا تاخذها")]
    public string NumberOfcasesMonthly { get; set; }

    public string? DocAppointments { get; set; }

    [Column("DocNID")]
    [StringLength(50)]
    public string? DocNid { get; set; }

    [StringLength(50)]
    [Display(Name = "الموبيل")]
    [Required(ErrorMessage = " ادخل رقم تليفونك")]

    public string DocPhone { get; set; }
    [Display(Name = "صور الدكتور")]
   // [Required(ErrorMessage = " ادخل صورتك")]

    public string? DocPhoto { get; set; }

    [Column("regionId"),
     ForeignKey(nameof(Region))]
      [Required(ErrorMessage =" ادخل الحالات التي تريد انا تاخذها")]

    public int? RegionId { get; set; }
    [Display(Name ="المركز")]
    public Region? region { get; set; }
    public SpecializatinTb? SpecializatinTb { get; set; }
    public AppointmentTB? AppointmentTB { get; set; }
}
