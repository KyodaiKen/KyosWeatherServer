using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TemplateApiCS.Database.Models
{
    [Table("location_defn")]
    public partial class LocationDefn
    {
        [Key]
        [Column("location_id")]
        [StringLength(4)]
        public string LocationId { get; set; } = null!;
        [Column("descr_long")]
        [StringLength(100)]
        public string DescrLong { get; set; } = null!;
        [Column("descr_short")]
        [StringLength(20)]
        public string DescrShort { get; set; } = null!;
        [Column("cardinal_direction")]
        [StringLength(3)]
        public string CardinalDirection { get; set; } = null!;
        [Column("color_tdew")]
        [StringLength(6)]
        public string ColorTdew { get; set; } = null!;
        [Column("border_tdew")]
        public float BorderTdew { get; set; }
        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
