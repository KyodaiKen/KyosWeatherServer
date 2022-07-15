using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TemplateApiCS.Database.Models
{
    [Table("data")]
    public partial class Datum
    {
        [Key]
        [Column("dttm", TypeName = "timestamp without time zone")]
        public DateTime Dttm { get; set; }
        [Key]
        [Column("location_id")]
        [StringLength(4)]
        public string LocationId { get; set; } = null!;
        [Key]
        [Column("sensor_id")]
        [StringLength(4)]
        public string SensorId { get; set; } = null!;
        [Column("value")]
        public float Value { get; set; }
    }
}
