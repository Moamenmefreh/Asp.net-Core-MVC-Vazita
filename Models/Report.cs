using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hayaat_Karima.Models;

[Keyless]
[Table("Report")]
public partial class Report
{
    [Column(TypeName = "datetime")]
    public DateTime? DateTimeOfReport { get; set; }

    [StringLength(255)]
    public string? DocName { get; set; }

    [Column("specializationIDFK")]
    [StringLength(255)]
    public string? SpecializationIdfk { get; set; }

    [StringLength(255)]
    public string? TechnicalLevel { get; set; }

    [Column("MCName")]
    [StringLength(255)]
    public string? Mcname { get; set; }

    [StringLength(255)]
    public string? Address { get; set; }

    [Column("RegIDFK")]
    [StringLength(255)]
    public string? RegIdfk { get; set; }

    [Column("MCContactPhone")]
    [StringLength(255)]
    public string? MccontactPhone { get; set; }

    [Column("NumberOFCasesMonthly")]
    public double? NumberOfcasesMonthly { get; set; }

    [StringLength(255)]
    public string? DocAppointments { get; set; }

    [StringLength(255)]
    public string? Notes { get; set; }

    [StringLength(255)]
    public string? NoName { get; set; }
}
