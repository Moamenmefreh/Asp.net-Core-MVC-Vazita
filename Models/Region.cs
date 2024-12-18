using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hayaat_Karima.Models;

public partial class Region
{
    [Key]
    [Column("PKRegionID")]
    public int PkregionId { get; set; }
    [Display(Name = "المركز")]
    public string? RegionName { get; set; }
    public IEnumerable<DoctorsTb>? doctorsregion { get; set; }
}
