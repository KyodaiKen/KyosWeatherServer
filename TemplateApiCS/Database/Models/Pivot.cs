using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TemplateApiCS.Database.Models
{
    [Keyless]
    public partial class Pivot
    {
        [Column("dttm", TypeName = "timestamp without time zone")]
        public DateTime? Dttm { get; set; }
        [Column("out1_temp")]
        public float? Out1Temp { get; set; }
        [Column("out1_relh")]
        public float? Out1Relh { get; set; }
        [Column("out1_tdew")]
        public string? Out1Tdew { get; set; }
        [Column("out1_ampp")]
        public float? Out1Ampp { get; set; }
        [Column("out1_illm")]
        public float? Out1Illm { get; set; }
        [Column("lvrm_temp")]
        public float? LvrmTemp { get; set; }
        [Column("lvrm_tdew")]
        public string? LvrmTdew { get; set; }
        [Column("lvrm_relh")]
        public float? LvrmRelh { get; set; }
        [Column("bdrm_temp")]
        public float? BdrmTemp { get; set; }
        [Column("bdrm_tdew")]
        public string? BdrmTdew { get; set; }
        [Column("bdrm_relh")]
        public float? BdrmRelh { get; set; }
        [Column("hall_temp")]
        public float? HallTemp { get; set; }
        [Column("hall_tdew")]
        public string? HallTdew { get; set; }
        [Column("hall_relh")]
        public float? HallRelh { get; set; }
    }
}
