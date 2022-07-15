using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TemplateApiCS.Database.Models;

namespace TemplateApiCS.Database
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Daily> Dailies { get; set; } = null!;
        public virtual DbSet<DataFault> DataFaults { get; set; } = null!;
        public virtual DbSet<Datum> Data { get; set; } = null!;
        public virtual DbSet<DayAll> DayAlls { get; set; } = null!;
        public virtual DbSet<DayAvg> DayAvgs { get; set; } = null!;
        public virtual DbSet<DayMax> DayMaxes { get; set; } = null!;
        public virtual DbSet<DayMin> DayMins { get; set; } = null!;
        public virtual DbSet<LocationDefn> LocationDefns { get; set; } = null!;
        public virtual DbSet<Monthly> Monthlies { get; set; } = null!;
        public virtual DbSet<Pivot> Pivots { get; set; } = null!;
        public virtual DbSet<SensorDefn> SensorDefns { get; set; } = null!;
        public virtual DbSet<Weekly> Weeklies { get; set; } = null!;
        public virtual DbSet<Yearly> Yearlies { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Daily>(entity =>
            {
                entity.ToView("daily");
            });

            modelBuilder.Entity<DataFault>(entity =>
            {
                entity.HasKey(e => new { e.Dttm, e.LocationId })
                    .HasName("data_faults_pkey");
            });

            modelBuilder.Entity<Datum>(entity =>
            {
                entity.HasKey(e => new { e.Dttm, e.LocationId, e.SensorId })
                    .HasName("data_pkey");
            });

            modelBuilder.Entity<DayAll>(entity =>
            {
                entity.ToView("day_all");
            });

            modelBuilder.Entity<DayAvg>(entity =>
            {
                entity.ToView("day_avg");
            });

            modelBuilder.Entity<DayMax>(entity =>
            {
                entity.ToView("day_max");
            });

            modelBuilder.Entity<DayMin>(entity =>
            {
                entity.ToView("day_min");
            });

            modelBuilder.Entity<LocationDefn>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("location_defn_pkey");
            });

            modelBuilder.Entity<Monthly>(entity =>
            {
                entity.ToView("monthly");
            });

            modelBuilder.Entity<Pivot>(entity =>
            {
                entity.ToView("pivot");
            });

            modelBuilder.Entity<SensorDefn>(entity =>
            {
                entity.HasKey(e => new { e.LocationId, e.SensorId })
                    .HasName("sensor_defn_pkey");
            });

            modelBuilder.Entity<Weekly>(entity =>
            {
                entity.ToView("weekly");
            });

            modelBuilder.Entity<Yearly>(entity =>
            {
                entity.ToView("yearly");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
