using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TemplateApiCS.Database.Models
{
    [Table("data_faults")]
    public partial class DataFault
    {
        [Key]
        [Column("dttm", TypeName = "timestamp without time zone")]
        public DateTime Dttm { get; set; }
        [Key]
        [Column("location_id")]
        [StringLength(4)]
        public string LocationId { get; set; } = null!;
        [Column("last_update_dttm", TypeName = "timestamp without time zone")]
        public DateTime? LastUpdateDttm { get; set; }
        [Column("error")]
        [StringLength(1)]
        public string Error { get; set; } = null!;
    }
}
