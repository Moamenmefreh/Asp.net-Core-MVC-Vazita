using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hayaat_Karima.Models;

[Table("ContactUSTB")]
public partial class ContactUstb
{
    [Key]
    [Column("ContactorID")]
    public int ContactorId { get; set; }

    [StringLength(50)]
    public string? ContactorName { get; set; }

    [StringLength(50)]
    public string? ContactorPhone { get; set; }

    public string? ContactorComment { get; set; }

    [Column("RegIDFK")]
    public int? RegIdfk { get; set; }
}
