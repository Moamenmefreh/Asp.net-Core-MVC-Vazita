using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hayaat_Karima.Models;

[Table("ReservationTB")]
public partial class ReservationTb
{
    [Key]
    [Column("ResvID")]
    public int ResvId { get; set; }

    [Column("McIDFK")]
    public int? McIdfk { get; set; }

    [Column("DocIdFK")]
    public int? DocIdFk { get; set; }

    public string? ResvAppointment { get; set; }
}
