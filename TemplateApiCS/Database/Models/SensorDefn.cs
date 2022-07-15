using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TemplateApiCS.Database.Models
{
    [Table("sensor_defn")]
    public partial class SensorDefn
    {
        [Key]
        [Column("location_id")]
        [StringLength(4)]
        public string LocationId { get; set; } = null!;
        [Key]
        [Column("sensor_id")]
        [StringLength(4)]
        public string SensorId { get; set; } = null!;
        [Column("descr_long")]
        [StringLength(100)]
        public string DescrLong { get; set; } = null!;
        [Column("descr_short")]
        [StringLength(20)]
        public string DescrShort { get; set; } = null!;
        [Column("unit")]
        [StringLength(6)]
        public string Unit { get; set; } = null!;
        [Column("color")]
        [StringLength(8)]
        public string Color { get; set; } = null!;
        [Column("border_width")]
        public float BorderWidth { get; set; }
        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
