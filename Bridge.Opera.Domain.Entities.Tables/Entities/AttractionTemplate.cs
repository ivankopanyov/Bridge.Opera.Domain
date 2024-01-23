using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Bridge.Opera.Domain.Entities.Tables
{
	public partial class AttractionTemplate
	{
	    public string AttractionCode { get; set; }
	    public string AttractionClass { get; set; }
	    public string AttractionType { get; set; }
	    public DateTime? InsertDate { get; set; }
	    public decimal? InsertUser { get; set; }
	    public DateTime? UpdateDate { get; set; }
	    public decimal? UpdateUser { get; set; }
	    public string Directions { get; set; }
	    public string Name { get; set; }
	    public string Address1 { get; set; }
	    public string Address2 { get; set; }
	    public string Address3 { get; set; }
	    public string Address4 { get; set; }
	    public string City { get; set; }
	    public string State { get; set; }
	    public string ZipCode { get; set; }
	    public string HoursOperation { get; set; }
	    public string GeneralDirections { get; set; }
	    public string Region { get; set; }
	    public DateTime? InactiveDate { get; set; }
	    public decimal? LatlongXPosition { get; set; }
	    public decimal? LatlongYPosition { get; set; }
	    public string CoordinateSupplier { get; set; }
	    public decimal? Distance { get; set; }
	    public string DistanceType { get; set; }
	    public string DrivingTime { get; set; }
	    public string Direction { get; set; }
	    public string PriceRange { get; set; }
	    public decimal? OrderBy { get; set; }
	    public string ChainCode { get; set; }
	    public string Website { get; set; }
	
		public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
		{
			modelBuilder.Entity<AttractionTemplate>(entity =>
	        {
	            entity.HasKey(e => new { e.ChainCode, e.AttractionCode })
	                .HasName("ATTRACTION_PK");
	
	            entity.ToTable("ATTRACTION_TEMPLATE");
	
	            entity.HasIndex(e => e.AttractionClass)
	                .HasName("ATTRACTION_N1");
	
	            entity.HasIndex(e => e.Name)
	                .HasName("ATTRACTION_N2");
	
	            entity.HasIndex(e => new { e.LatlongYPosition, e.LatlongXPosition, e.AttractionCode })
	                .HasName("ATTRACTION_LL");
	
	            entity.Property(e => e.ChainCode)
	                .HasColumnName("CHAIN_CODE")
	                .HasMaxLength(20)
	                .IsUnicode(false)
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.AttractionCode)
	                .HasColumnName("ATTRACTION_CODE")
	                .HasMaxLength(20)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Address1)
	                .HasColumnName("ADDRESS1")
	                .HasMaxLength(80)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Address2)
	                .HasColumnName("ADDRESS2")
	                .HasMaxLength(80)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Address3)
	                .HasColumnName("ADDRESS3")
	                .HasMaxLength(80)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Address4)
	                .HasColumnName("ADDRESS4")
	                .HasMaxLength(80)
	                .IsUnicode(false);
	
	            entity.Property(e => e.AttractionClass)
	                .HasColumnName("ATTRACTION_CLASS")
	                .HasMaxLength(60)
	                .IsUnicode(false);
	
	            entity.Property(e => e.AttractionType)
	                .HasColumnName("ATTRACTION_TYPE")
	                .HasMaxLength(60)
	                .IsUnicode(false);
	
	            entity.Property(e => e.City)
	                .HasColumnName("CITY")
	                .HasMaxLength(80)
	                .IsUnicode(false);
	
	            entity.Property(e => e.CoordinateSupplier)
	                .HasColumnName("COORDINATE_SUPPLIER")
	                .HasMaxLength(80)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Direction)
	                .HasColumnName("DIRECTION")
	                .HasMaxLength(20)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Directions)
	                .HasColumnName("DIRECTIONS")
	                .HasMaxLength(2000)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Distance)
	                .HasColumnName("DISTANCE")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.DistanceType)
	                .HasColumnName("DISTANCE_TYPE")
	                .HasMaxLength(20)
	                .IsUnicode(false);
	
	            entity.Property(e => e.DrivingTime)
	                .HasColumnName("DRIVING_TIME")
	                .HasMaxLength(20)
	                .IsUnicode(false);
	
	            entity.Property(e => e.GeneralDirections)
	                .HasColumnName("GENERAL_DIRECTIONS")
	                .HasMaxLength(2000)
	                .IsUnicode(false);
	
	            entity.Property(e => e.HoursOperation)
	                .HasColumnName("HOURS_OPERATION")
	                .HasMaxLength(20)
	                .IsUnicode(false);
	
	            entity.Property(e => e.InactiveDate)
	                .HasColumnName("INACTIVE_DATE")
	                .HasColumnType("DATE");
	
	            entity.Property(e => e.InsertDate)
	                .HasColumnName("INSERT_DATE")
	                .HasColumnType("DATE");
	
	            entity.Property(e => e.InsertUser)
	                .HasColumnName("INSERT_USER")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.LatlongXPosition)
	                .HasColumnName("LATLONG_X_POSITION")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.LatlongYPosition)
	                .HasColumnName("LATLONG_Y_POSITION")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.Name)
	                .HasColumnName("NAME")
	                .HasMaxLength(80)
	                .IsUnicode(false);
	
	            entity.Property(e => e.OrderBy)
	                .HasColumnName("ORDER_BY")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.PriceRange)
	                .HasColumnName("PRICE_RANGE")
	                .HasMaxLength(40)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Region)
	                .HasColumnName("REGION")
	                .HasMaxLength(20)
	                .IsUnicode(false);
	
	            entity.Property(e => e.State)
	                .HasColumnName("STATE")
	                .HasMaxLength(80)
	                .IsUnicode(false);
	
	            entity.Property(e => e.UpdateDate)
	                .HasColumnName("UPDATE_DATE")
	                .HasColumnType("DATE");
	
	            entity.Property(e => e.UpdateUser)
	                .HasColumnName("UPDATE_USER")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.Website)
	                .HasColumnName("WEBSITE")
	                .HasMaxLength(2000)
	                .IsUnicode(false);
	
	            entity.Property(e => e.ZipCode)
	                .HasColumnName("ZIP_CODE")
	                .HasMaxLength(20)
	                .IsUnicode(false);
	        });
		}
	}
}
	