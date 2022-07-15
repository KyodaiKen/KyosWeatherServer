using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TemplateApiCS.Database.Models
{
    [Keyless]
    public partial class DayAvg
    {
        [Column("date", TypeName = "timestamp without time zone")]
        public DateTime? Date { get; set; }
        [Column("location_id")]
        [StringLength(4)]
        public string? LocationId { get; set; }
        [Column("sensor_id")]
        [StringLength(4)]
        public string? SensorId { get; set; }
        [Column("value")]
        public double? Value { get; set; }
    }
}
