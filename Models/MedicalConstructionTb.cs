using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hayaat_Karima.Models;

[Table("MedicalConstructionTB")]
public partial class MedicalConstructionTb
{
    [Key]
    [Column("MCIDPK")]
    public int Mcidpk { get; set; }

    [Column("MCName")]
    [StringLength(50)]
    public string? Mcname { get; set; }

    [Column("doctorsIDFK")]
    public int? DoctorsIdfk { get; set; }

    [Column("MCaddress")]
    [StringLength(50)]
    public string? Mcaddress { get; set; }

    [Column("RegIDFK")]
    public int? RegIdfk { get; set; }

    [Column("MCContactPhone")]
    [StringLength(50)]
    public string? MccontactPhone { get; set; }

    [Column("specializationIDFK")]
    public int? SpecializationIdfk { get; set; }

    [Column("MCType")]
    [StringLength(50)]
    public string? Mctype { get; set; }
}
