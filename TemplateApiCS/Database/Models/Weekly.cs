using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TemplateApiCS.Database.Models
{
    [Keyless]
    public partial class Weekly
    {
        [Column("date", TypeName = "timestamp without time zone")]
        public DateTime? Date { get; set; }
        [Column("location_id")]
        [StringLength(4)]
        public string? LocationId { get; set; }
        [Column("sensor_id")]
        [StringLength(4)]
        public string? SensorId { get; set; }
        [Column("min")]
        public float? Min { get; set; }
        [Column("avg")]
        public double? Avg { get; set; }
        [Column("max")]
        public float? Max { get; set; }
    }
}
