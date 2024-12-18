using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hayaat_Karima.Models;

[Table("SpecializatinTB")]
public partial class SpecializatinTb
{
    [Key]
    [Column("SpecializatinIDPK")]
    public int SpecializatinIdpk { get; set; }

    [StringLength(50)]
    [Display(Name = "التخصص")]
    public string? SpecializatinName { get; set; }
    public IEnumerable<DoctorsTb>? Doctorsspecial { get; set; }
}
