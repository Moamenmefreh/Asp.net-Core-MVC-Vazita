using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hayaat_Karima.Models;

[Table("DecentLifeDeserversTB")]
public partial class DecentLifeDeserversTb
{
    [Key]
    [Column("DeserversID")]
    public int DeserversId { get; set; }

    [StringLength(50)]
    public string? DeserversName { get; set; }

    [Column("RegIDFK")]
    public int? RegIdfk { get; set; }

    [Column("DeserverNID")]
    [StringLength(14)]
    public string? DeserverNid { get; set; }

    public bool? DeserverGender { get; set; }

    [StringLength(50)]
    public string? Deserverphone { get; set; }

    [Column("DeserverDateOFBirth", TypeName = "date")]
    public DateTime? DeserverDateOfbirth { get; set; }

    public string? DeserverAttatchmentsCompressedFolder { get; set; }
}
