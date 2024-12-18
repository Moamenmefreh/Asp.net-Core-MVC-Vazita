using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hayaat_Karima.Models;

[Table("ReservationCardTB")]
public partial class ReservationCardTb
{
    [Key]
    [Column("CardID")]
    public int CardId { get; set; }

    [StringLength(50)]
    public string? MedicalConstractionName { get; set; }

    [StringLength(50)]
    public string? DesrversName { get; set; }

    [Column("appointment", TypeName = "datetime")]
    public DateTime? Appointment { get; set; }

    [Column("address")]
    [StringLength(50)]
    public string? Address { get; set; }
}
